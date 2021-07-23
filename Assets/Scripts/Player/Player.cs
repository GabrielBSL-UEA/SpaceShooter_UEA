using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class Player : GameEntity, IHittable
{
    private enum AnimList
    {
        player_idle,
        player_left,
        player_right
    }
    
    [Serializable]
    public struct Shoot
    {
        public GameObject shootObj;
        public float timeBetweenShots;
    }

    public Shoot[] weaponList;
    private int currentWeapon = 0;
    
    public float velocity = 5f;
    public Transform shotSpawnPoint;
    
    private Animator anim;
    private string currentAnim;
    private float shotTimer = Mathf.Infinity;
    private bool canShoot = false;
    
    private PlayerInputs inputActions;
    private Vector2 moveDirection;
    private BoxCollider2D boxCol;

    private Vector3 bottomLeft;
    private Vector3 topRight;
    private Rect cameraRect;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        anim = GetComponent<Animator>();
        boxCol = GetComponent<BoxCollider2D>();

        inputActions = new PlayerInputs();

        inputActions.Spaceship.Movement.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        inputActions.Spaceship.Movement.canceled += ctx => moveDirection = Vector2.zero;

        inputActions.Spaceship.Shoot.performed += ctx => ShotButton(ctx);
        inputActions.Spaceship.Shoot.canceled += ctx => ShotButton(ctx);

        inputActions.Spaceship.WeaponPlus.performed += ctx => ChangeWeapon(true);
        inputActions.Spaceship.WeaponMinus.performed += ctx => ChangeWeapon(false);
        
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);
        topRight = Camera.main.ScreenToWorldPoint(
            new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight));

        cameraRect = new Rect(
            bottomLeft.x,
            bottomLeft.y,  
            topRight.x - bottomLeft.x,
            topRight.y - bottomLeft.y
        );
    }

    private void OnEnable() => inputActions.Enable();
    private void OnDisable() => inputActions.Disable();

    private void Update()
    {
        if (shotTimer >= weaponList[currentWeapon].timeBetweenShots && canShoot)
        {
            ShootAction();
            shotTimer = 0;
        }
        else
        {
            shotTimer += Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection * velocity;

        float clampX = Mathf.Clamp(rb.position.x, cameraRect.xMin + boxCol.bounds.extents.x, cameraRect.xMax - boxCol.bounds.extents.x);
        float clampY = Mathf.Clamp(rb.position.y, cameraRect.yMin + boxCol.bounds.extents.y, cameraRect.yMax - boxCol.bounds.extents.y);

        rb.position = new Vector2(clampX, clampY);
        
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (rb.velocity.x > 0) PlayAnimation(AnimList.player_right.ToString());
        else if (rb.velocity.x < 0) PlayAnimation(AnimList.player_left.ToString());
        else PlayAnimation(AnimList.player_idle.ToString());
    }

    private void PlayAnimation(string animName)
    {
        if(currentAnim == animName) return;
        
        anim.Play(animName);
    }

    private void ShotButton(InputAction.CallbackContext ctx)
    {
        canShoot = ctx.performed;
    }

    private void ShootAction()
    {
        Instantiate(weaponList[currentWeapon].shootObj, shotSpawnPoint.position, shotSpawnPoint.rotation);
        AudioManager.Instance.Play(AudioList.PlayerShoot);
    }

    private void ChangeWeapon(bool right)
    {
        currentWeapon += right ? 1 : -1;

        if (currentWeapon >= weaponList.Length) currentWeapon = 0;
        else if (currentWeapon < 0) currentWeapon = weaponList.Length - 1;
    }

    public void RegisterHit()
    {
        PlayerSpawner.Instance.InstantiateSpaceship(3);
        DestroyObject();
    }

    public override void DestroyObject()
    {
        base.DestroyObject();
        AudioManager.Instance.Play(AudioList.PlayerExplosion);
        Destroy(gameObject);
    }
}

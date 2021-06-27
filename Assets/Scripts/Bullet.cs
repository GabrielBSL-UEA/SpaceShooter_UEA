using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    [SerializeField] private float damage;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) return;

        GetComponent<Rigidbody2D>().AddForce(Vector3.up * speed, ForceMode2D.Impulse);

        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<IHittable>().RegisterHit();
            Destroy(gameObject);
        }
    }
}

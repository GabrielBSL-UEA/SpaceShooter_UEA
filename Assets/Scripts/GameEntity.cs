using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] private GameObject explosionVFX;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void DestroyObject()
    {
        Instantiate(explosionVFX, transform.position, Quaternion.identity);
    }
}

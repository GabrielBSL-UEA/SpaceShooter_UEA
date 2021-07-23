using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Enemy, IHittable
{
    protected override void Awake()
    {
        base.Awake();
        rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            collision.GetComponent<IHittable>().RegisterHit();
            DestroyObject();
        };
    }
    public void RegisterHit()
    {
        AudioManager.Instance.Play(AudioList.AsteroidExplosion);
        DestroyObject();
    }
}

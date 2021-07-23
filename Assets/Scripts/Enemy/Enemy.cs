using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameEntity
{
    [SerializeField] protected int points = 100;
    [SerializeField] protected float speed;

    public override void DestroyObject()
    {
        base.DestroyObject();

        GameController.Instance.AddScore(points);
        Destroy(gameObject);
    }
}

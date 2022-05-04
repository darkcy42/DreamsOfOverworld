using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;

    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if(Hitpoints <= 1)
        {
            Destroy(gameObject); 
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        
    }


    void Update()
    {
        
    }
}

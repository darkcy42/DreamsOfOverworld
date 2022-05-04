using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    bool facingRight = true; 

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyBehavior>();
        if(enemy)
        {
            enemy.TakeHit(1);
        }

        Destroy(gameObject);
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
} 




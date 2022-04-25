using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 1;
    public float Jump = 1;
    private Rigidbody2D rb;
    public Bullet bulletPrefab;
    public Transform LaunchOffset;
    bool facingRight = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
       var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Speed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, Jump), ForceMode2D.Impulse);
        }    
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, LaunchOffset.position, transform.rotation);
        }
        if(movement < 0 && facingRight)
        {
            flip();
        }
        if (movement > 0 && !facingRight)
        {
            flip();
        }
    }
    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
} 



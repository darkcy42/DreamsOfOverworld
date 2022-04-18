using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 1;


    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
       var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Speed;
    }

}


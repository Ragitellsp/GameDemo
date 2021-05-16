﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=2;
    public float lifeTime=2;
    public bool left;
    // Start is called before the first frame update
     private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
     private void Update()
    {
        if(left)
        {
            transform.Translate(Vector2.left*speed*Time.deltaTime);
        }
        else 
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}

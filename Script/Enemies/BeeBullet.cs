using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBullet : MonoBehaviour
{
    public float speed =2;
    public float leftTime=2;
    // Start is called before the first frame update
     private void Start()
    {
        Destroy(gameObject,leftTime);
    }

    // Update is called once per frame
     private void Update()
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borular : MonoBehaviour
{
    public float  speed;
    private void Start()
    {
        Destroy(gameObject,200);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;   
    }
}

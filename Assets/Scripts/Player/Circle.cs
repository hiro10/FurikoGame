using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public Rigidbody rigidbody;
    private float speed;
    private float radius;
    private float yposition;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1.0f;
        radius = 2.0f;
        yposition = 0.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(
            new Vector3(
                radius * Mathf.Sin(Time.time * speed),
                yposition, 
                radius * Mathf.Cos(Time.time*speed))
            );

           
        
    }
}

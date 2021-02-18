using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate: MonoBehaviour
{
    private Rigidbody rb;
    private float jumpSpeed;
    private float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void jumpButton()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

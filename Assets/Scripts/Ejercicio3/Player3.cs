using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    float horizontal, vertical;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {   
        vertical=Input.GetAxis("Vertical");
        horizontal=Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal*speed,0,vertical*speed);
    }
}

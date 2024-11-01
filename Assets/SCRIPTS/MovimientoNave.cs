using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    
    [SerializeField] float velocidad;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
          
        
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = transform.rotation * new Vector3(HorizontalMove(), 0, 0) * ActualSpeed();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -75, 75), 0, 0);
    }

    public float HorizontalMove()
    {
        return Input.GetAxis("Horizontal");
    }
       
    public float ActualSpeed()
    {
        return velocidad;
    }

}

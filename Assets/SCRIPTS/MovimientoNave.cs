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
        rb.velocity = transform.rotation * new Vector3(Mathf.Clamp(HorizontalMove(), -110, 100), 0, 0) * ActualSpeed();
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

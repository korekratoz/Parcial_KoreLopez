using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] int daño;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
                
    }

    private void FixedUpdate()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        rb.velocity= transform.rotation * new Vector3(0, 0, -1) * fuerza;
        StartCoroutine(Contador());
    }

    IEnumerator Contador()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        VidaNave nave = collision.rigidbody.GetComponent<VidaNave>();
        if (nave != null)
        {
            
            nave.DañoRecibido(daño);

            Destroy(this.gameObject);

        }
    }


}

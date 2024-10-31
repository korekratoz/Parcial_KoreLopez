using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float fuerza;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        StartCoroutine(Movimiento());

    }

    IEnumerator Movimiento()
    {
        yield return new WaitForSeconds(.5f);
        rb.AddForce(0, 0,fuerza);
        Destroy(this.gameObject, 10);
    }


}

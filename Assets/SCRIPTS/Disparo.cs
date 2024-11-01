using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] Transform balaPrefab;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerzaDisparo;
    [SerializeField] AudioManager sfx;
   
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            sfx.PlaySFX("Disparo");
            GameObject clone = Instantiate(balaPrefab, puntoDisparo.position, balaPrefab.rotation).gameObject;
            clone.GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaDisparo);
            Destroy(clone, 5);
            
        }
        
    }
}

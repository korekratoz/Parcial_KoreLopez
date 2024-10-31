using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] Transform balaPrefab;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerzaDisparo;

   
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(balaPrefab, puntoDisparo.position, balaPrefab.rotation).gameObject;
            clone.GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaDisparo);
            Destroy(clone, 5);
            
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaNave : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Enemigo"))
            Destroy(this.gameObject);
        StartCoroutine(Finalizar());
    }

    IEnumerator Finalizar()
    {
        yield return new WaitForSeconds(5);
        Environment.Exit(0);
    }

}

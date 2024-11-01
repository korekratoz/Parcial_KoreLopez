using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaNave : MonoBehaviour
{
    [SerializeField] int vida;
    public void DañoRecibido(int daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
            Destruir();
        }

        void Destruir()
        {
            Destroy(this.gameObject);

            GameObject.FindGameObjectWithTag("Manager").GetComponent<Tiempo>().StopAllCoroutines();
            
        }

    }

}

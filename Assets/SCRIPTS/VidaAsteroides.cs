using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaAsteroides : MonoBehaviour
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

            GameObject.FindGameObjectWithTag("Manager").GetComponent<Contador>().destruidos++;

        }

    }
    
}

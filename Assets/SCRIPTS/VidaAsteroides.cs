using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaAsteroides : MonoBehaviour
{
    [SerializeField] int vida;

    public void Da�oRecibido(int da�o)
    {
        vida -= da�o;

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

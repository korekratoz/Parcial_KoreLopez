using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaAsteroides : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] AudioManager sfx;

    public void Start()
    {
        sfx = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

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
            sfx.PlaySFX("Explosion");
            GameObject.FindGameObjectWithTag("Manager").GetComponent<Contador>().destruidos++;

        }

    }
    
}

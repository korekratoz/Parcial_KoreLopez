using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBala : MonoBehaviour
{
    [SerializeField] int daño;
    [SerializeField] AudioManager sfx;

    public void Start()
    {
        sfx = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        VidaAsteroides asteroide = collision.rigidbody.GetComponent<VidaAsteroides>();
        if (asteroide != null)
        {
            sfx.PlaySFX("Impacto");

            asteroide.DañoRecibido(daño);

            Destroy(this.gameObject);

        }
    }

}

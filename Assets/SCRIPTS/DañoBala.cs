using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBala : MonoBehaviour
{
    [SerializeField] int daño;

    private void OnCollisionEnter(Collision collision)
    {
        VidaAsteroides asteroide = collision.rigidbody.GetComponent<VidaAsteroides>();
        if (asteroide != null)
        {
            asteroide.DañoRecibido(daño);

            Destroy(this.gameObject);

        }
    }

}

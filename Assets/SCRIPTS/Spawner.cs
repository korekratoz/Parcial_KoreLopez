using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] Transform asteroide;
    [SerializeField] Vector3 spawnPoint;
    [SerializeField] int tiempoAparicion;
    private float rangoX;

    private void Start()
    {
        StartCoroutine(TiempoInvocacion());
    }

    IEnumerator TiempoInvocacion()
    {
        yield return new WaitForSeconds(2);
        InvocarAsteroide();
        StartCoroutine(TiempoInvocacion());
    }


    void InvocarAsteroide()
    {
        rangoX = Random.Range(-75, 75);
        spawnPoint = new Vector3(rangoX, 170, -2.5f);
        Instantiate(asteroide,spawnPoint, asteroide.rotation);

    }

}

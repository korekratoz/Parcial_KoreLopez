using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] Transform asteroide;
    [SerializeField] Vector3 spawnPoint;
    [SerializeField] int tiempoAparicion;
    [SerializeField] float rangoX;

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
        rangoX = Random.Range(-100, 100);
        spawnPoint = new Vector3(rangoX, 3.5f, 130);
        Instantiate(asteroide,spawnPoint, asteroide.rotation);

    }

}

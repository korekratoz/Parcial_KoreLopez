using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{

    int tiempoVivo;
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        StartCoroutine(Contador());
    }

    IEnumerator Contador()
    {
        WaitForSeconds tiempo = new WaitForSeconds(1);

        while (true)
        {
            text.text = "Tiempo: " + tiempoVivo.ToString();
            yield return tiempo;
            tiempoVivo++;
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    [SerializeField] GameObject salir;

    public void Update()
    {
        Pausar();

    }

    public void Pausar()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        salir.SetActive(true);
    }

    public void Cerrar()
    {
        Application.Quit();
    }

}

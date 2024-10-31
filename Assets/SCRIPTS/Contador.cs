using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    [SerializeField] public int destruidos;
    [SerializeField] public TextMeshProUGUI contador;

    private void Start()
    {
        
    }

    public void Update()
    {
        contador.text = $"Asteroides: {destruidos}";
    }

}

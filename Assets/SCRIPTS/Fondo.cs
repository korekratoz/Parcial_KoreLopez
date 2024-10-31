using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fondo : MonoBehaviour
{

    [SerializeField] RawImage imagen;
    [SerializeField] float x, y;

    private void Update()
    {
        imagen.uvRect = new Rect(imagen.uvRect.position + new Vector2(x, y) * Time.deltaTime, imagen.uvRect.size);
    }


}

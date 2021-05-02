using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CambiarColorColision : MonoBehaviour
{

    private AudioSource sonido1;

    private void Start() {
        sonido1 = GetComponent<AudioSource> ();
    }


    private void OnCollisionEnter (Collision target)
    {
        if(target.gameObject.name.Equals("base") == true ) 
        {
            Color randomlySelectedColor = GetRandomColor();
            GetComponent<Renderer>().material.color = randomlySelectedColor;   
            sonido1.Play ();
        }
    }

    // Update is called once per frame
    private Color GetRandomColor()
    {
        return new Color(
            r:UnityEngine.Random.Range(0f, 1f),
            g:UnityEngine.Random.Range(0f, 1f),
            b:UnityEngine.Random.Range(0f, 1f));
    }
}

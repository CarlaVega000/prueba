using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Elemento2 : MonoBehaviour
{

    private AudioSource sonido2;

    private void Start() {
        sonido2 = GetComponent<AudioSource> ();
    }


    private void OnCollisionEnter (Collision target)
    {
        if(target.gameObject.name.Equals("base") == true ) 
        {
            Color randomlySelectedColor = GetRandomColor();
            GetComponent<Renderer>().material.color = randomlySelectedColor;   
            sonido2.Play ();
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

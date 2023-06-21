using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarTiro : MonoBehaviour
{
    public float velocidadeTiro;
    public int danoDado;
    void Start()
    {
        
    }
    void Update()
    {
        MovimentarTiro();
    }
    private void MovimentarTiro()
    {
        transform.Translate(Vector3.right * velocidadeTiro * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Inimigo"))
        {
            col.gameObject.GetComponent<VIdaInimigos>().MachucarInimigo(danoDado);
            Destroy(this.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chefe : MonoBehaviour 
{

    public float distanciaMin;

    private float distancia;
    private GameObject visaoChefe;

    public float velocidadeChefe;
    private Transform posicaoChefe;
    public GameObject posicaoVisao;
    void Start()
    {
        distancia = Vector3.Distance (transform.position, visaoChefe.transform.position);

        if (distancia <= distanciaMin)
        {
            visaoChefe = GameObject.FindGameObjectWithTag("visaoChefe");
        }
    }


    void Update ()
    {
       Seguir();
    }
    
    private void Seguir()
    {
        if (posicaoChefe.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicaoChefe.position, velocidadeChefe * Time.deltaTime);  
        }
       
    }
}

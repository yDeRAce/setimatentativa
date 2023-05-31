using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaVivo : MonoBehaviour
{
    private Transform posicaoNave;
    public float velocidadePlanetaVivo;
    void Start()
    {
        posicaoNave = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Seguir();
    }

    private void Seguir()
    {
        if (posicaoNave.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicaoNave.position, velocidadePlanetaVivo * Time.deltaTime);  
        }
       
    }
 
}

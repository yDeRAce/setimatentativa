using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrelaCadente : MonoBehaviour
{
    public float velocidadeEstrelaCadente;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Movimentar();
    }
    
    private void Movimentar()
    {
        transform.Translate(Vector3.left * velocidadeEstrelaCadente * Time.deltaTime);
    }
}

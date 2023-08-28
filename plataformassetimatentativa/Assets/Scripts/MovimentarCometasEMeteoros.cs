using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarCometasEMeteoros : MonoBehaviour
{
    public float velocidade;
    
    void Start()
    {
        Movimentar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Movimentar()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}

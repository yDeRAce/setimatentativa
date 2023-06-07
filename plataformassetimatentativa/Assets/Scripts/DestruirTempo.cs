using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirTempo : MonoBehaviour
{
    public float tempoDeVida;
    void Start()
    {
        Destroy(this.gameObject, tempoDeVida);
    }

    
    void Update()
    {
        
    }
}

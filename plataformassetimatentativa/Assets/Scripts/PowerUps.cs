using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public bool caixaAzulL;
    public bool caixaVEscudo;
    public bool estrela;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (caixaVEscudo == true)
            {
                other.gameObject.GetComponent<VidaNave>().AtivarEScudo();
            }
            if (caixaAzulL == true)
            {
                
            }

            if (estrela == true)
            {
                other.gameObject.GetComponent<VidaNave>().GanharVIda();
            }
        }
    }
}

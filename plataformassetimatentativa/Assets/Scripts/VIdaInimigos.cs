using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIdaInimigos : MonoBehaviour
{
    public int vidaInicialInimigo;
    public int VidaAtualInimigo;
    
    void Start()
    {
        VidaAtualInimigo = vidaInicialInimigo;
    }
    
    void Update()
    {
       
    }

    public void MachucarInimigo(int danoRecebido)
    {
        VidaAtualInimigo -= danoRecebido;

        if (VidaAtualInimigo <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

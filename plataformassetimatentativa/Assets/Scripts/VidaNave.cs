using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaNave : MonoBehaviour
{
    public int vidaInicialNave;
    public int vidaAtualNave;
    public bool escudoAtivo;
    void Start()
    {
        vidaAtualNave = vidaInicialNave;
    }
    
    void Update()
    {
      
    }

    public void DanoNave(int danoRecebido)
    {
        if (escudoAtivo == false)
        {
            vidaAtualNave -= danoRecebido;
            
            if (vidaAtualNave <= 0)
            {
                Debug.Log("GAME OVER: PERDEU PLAYERBOY");
            }
        }
        
        else
        {
            
        }
    }
}

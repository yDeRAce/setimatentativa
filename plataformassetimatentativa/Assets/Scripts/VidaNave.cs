using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaNave : MonoBehaviour
{
    public Slider barraDeVidaNave;
    
    public int vidaInicialNave;
    public int vidaAtualNave;
    public bool escudoAtivo;
    void Start()
    {
        vidaAtualNave = vidaInicialNave;
        barraDeVidaNave.maxValue = vidaInicialNave;
        barraDeVidaNave.value = vidaAtualNave;
    }
    
    void Update()
    {
      
    }

    public void DanoNave(int danoRecebido)
    {
        if (escudoAtivo == false)
        {
            vidaAtualNave -= danoRecebido;
            barraDeVidaNave.value = vidaAtualNave;
            
            if (vidaAtualNave <= 0)
            {
                Debug.Log("GAME OVER: PERDEU PLAYERBOY");
            }
        }
        
    }
}

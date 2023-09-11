using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaNave : MonoBehaviour
{
    public Slider barraDeVidaNave;
    public GameObject escudoDaNave;
    
    public int vidaInicialNave;
    public int vidaAtualNave;
    public int vidaRecebida;
    
    public bool escudoAtivo;
    public int vidaMaxEscudo;
    public int vidaAtualEscudo;
    void Start()
    {
        vidaAtualNave = vidaInicialNave;
        vidaAtualEscudo = vidaMaxEscudo;
        barraDeVidaNave.maxValue = vidaInicialNave;
        barraDeVidaNave.value = vidaAtualNave;
        escudoDaNave.SetActive(false);
    }
    
    void Update()
    {
    
    }

    public void AtivarEScudo()
    {
        vidaAtualEscudo = vidaMaxEscudo;
        escudoDaNave.SetActive(true);
        escudoAtivo = true;
    }

    public void GanharVIda()
    {
        if (vidaAtualNave + vidaRecebida <= vidaInicialNave)
        {
            vidaAtualNave += vidaRecebida;
        }
        else
        {
            vidaAtualNave = vidaInicialNave;
        }

        barraDeVidaNave.value = vidaAtualNave;
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
        else
        {
            vidaAtualEscudo -= danoRecebido;

            if (vidaAtualEscudo <= 0)
            {
                escudoDaNave.SetActive(false);
                escudoAtivo = false;
            }
        }
        
    }
}

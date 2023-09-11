using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VIdaInimigos : MonoBehaviour
{
    public int vidaInicialInimigo;
    public int VidaAtualInimigo;

    public int pontosGanhados;
    
    public int danoDado;
    
    void Start()
    {
        VidaAtualInimigo = vidaInicialInimigo;
    }
    
    void Update()
    {
       
    }

    public void MachucarInimigo(int danoRecebidoInimigo)
    {
        VidaAtualInimigo -= danoRecebidoInimigo;

        if (VidaAtualInimigo <= 0)
        {
            GameManager.instance.AumentarPontos(pontosGanhados);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D()
    {
        if (gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<VidaNave>().DanoNave(danoDado);
        }
    }
}

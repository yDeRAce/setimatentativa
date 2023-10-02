using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VIdaInimigos : MonoBehaviour
{
    public int vidaInicialInimigo;
    public int VidaAtualInimigo;
    public int inimigosDerrotados;

    public int pontosGanhados;
    public int chanceDrope;
    
    public int danoDado;
    public GameObject itemDropado;

    void Start()
    {
        VidaAtualInimigo = vidaInicialInimigo;
        inimigosDerrotados = 0;
    }

    void Update()
    {
       
    }

    public void MachucarInimigo(int danoRecebidoInimigo)
    {
        VidaAtualInimigo -= danoRecebidoInimigo;

        if (VidaAtualInimigo <= 0)
        {
            int numeroAleatorio = Random.Range(1, 50);
            if (numeroAleatorio <= chanceDrope)
            {
                
            }
            
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

    
    public void AumentarPontos(int pontosGanhos)
    {
        inimigosDerrotados += pontosGanhos;
    }
}

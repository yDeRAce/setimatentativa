using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALIEN : MonoBehaviour
{
    public GameObject laser;
    public Transform localDisparo;
    
    public float velocidadeAlien;

    public int vidaInicialAlien;
    public int vidaAtualAlien;

    public float tempoMaxEntreLasers;
    public float tempoAtualLasers;
    void Start()
    {
        vidaAtualAlien = vidaInicialAlien;
    }


    void Update()
    {
        MovimentarAlien();
        AtirarLaser();
    }

    private void MovimentarAlien()
    {
        transform.Translate(Vector3.down * velocidadeAlien * Time.deltaTime);
    }

    private void AtirarLaser()
    {
        tempoAtualLasers -= Time.deltaTime;

        if (tempoAtualLasers <= 0)
        {
            Instantiate(laser, localDisparo.position, Quaternion.Euler(0f, 0f, 0f));
            tempoAtualLasers = tempoMaxEntreLasers;
        }
    }

    public void DanoNoAlien(int danoRecebidoAlien)
    {
        vidaAtualAlien -= danoRecebidoAlien();
        
        if (vidaAtualAlien <= 0) 
        {
            Destroy(this.gameObject);
        }

    }
    
}

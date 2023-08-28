using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveInimiga : MonoBehaviour
{
    public GameObject laser;
    public Transform localDisparo;
    
    public float velocidadeNaveAzul;

    public int vidaInicialNave;
    public int vidaAtualNave;

    public float tempoMaxEntreLasers;
    public float tempoAtualLasers;
    void Start()
    {
        vidaAtualNave = vidaInicialNave;
    }


    void Update()
    {
        MovimentarNave();
        AtirarLaser();
    }

    private void MovimentarNave()
    {
        transform.Translate(Vector3.down * velocidadeNaveAzul * Time.deltaTime);
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
}

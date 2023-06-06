using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALIEN : MonoBehaviour
{
    public GameObject laser;
    public Transform localDisparo;
    
    public float velocidadeAlien;

    public float tempoMaxEntreLasers;
    public float tempoAtualLasers;
    void Start()
    {
        
    }


    void Update()
    {
        MovimentarAlien();
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
            Instantiate(laser, localDisparo.position, Quaternion.Euler());
        }
    }
}
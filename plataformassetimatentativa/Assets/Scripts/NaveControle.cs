using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NaveControle : MonoBehaviour
{
    public int vida;
    public Rigidbody2D oRigidBody2D;

    public bool temlaserDuplo;
    public GameObject tiroDuplo;
    public Transform localUm;
    public Transform localDois;
    public float tempoMaxLaserD;
    public float tempoALaserD;
    
    public GameObject tiroNave;
    public Transform localDisparo;
    
    public float velocidadeNave;
    private Vector2 teclasApertadas;
    
    void Start()
    {
        temlaserDuplo = false;
        tempoALaserD = tempoMaxLaserD;
    }
    
    void Update()
    {
        MovimentarNave();
        Atirar();
        if (temlaserDuplo == true)
        {
            tempoALaserD -= Time.deltaTime;
            if (tempoALaserD <= 0)
            {
                DesativarLaserD();
            }
        }
    }

    private void MovimentarNave()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidBody2D.velocity = teclasApertadas.normalized * velocidadeNave;
    }

    private void Atirar()
    {
        if (temlaserDuplo == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(tiroNave, localDisparo.position, localDisparo.rotation);
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(tiroDuplo, localUm.position, localUm.rotation);
                Instantiate(tiroDuplo, localDois.position, localDois.rotation);
            }
        }
    }

    private void DesativarLaserD()
    {
        temlaserDuplo = false;
        tempoALaserD = tempoMaxLaserD;
    }
}

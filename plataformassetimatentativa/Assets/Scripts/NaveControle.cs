using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControle : MonoBehaviour
{
    public Rigidbody2D oRigidBody2D;
    
    public GameObject tiroNave;
    public Transform localDisparo;
    
    public float velocidadeNave;
    private Vector2 teclasApertadas;
    void Start()
    {
        
    }
    void Update()
    {
        MovimentarNave();
        Atirar();
    }
    private void Atirar()
    {
        if(Input.GetButtonDown("Fire1"));
        {
            Instantiate(tiroNave, localDisparo.position, localDisparo.rotation);
        }
    }
    private void MovimentarNave()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidBody2D.velocity = teclasApertadas.normalized * velocidadeNave;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarTiro : MonoBehaviour
{
    public float velocidadeTiro;
    public int danoDadoAlien;
    void Start()
    {
        
    }
    void Update()
    {
        MovimentarTiro();
    }
    private void MovimentarTiro()
    {
        transform.Translate(Vector3.right * velocidadeTiro * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alien"))
        {
            col.gameObject.GetComponent<ALIEN>().DanoNoAlien(danoDadoAlien);
            Destroy(this.gameObject);
        }
    }
}
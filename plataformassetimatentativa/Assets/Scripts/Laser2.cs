using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2 : MonoBehaviour
{
    public float velocidadeLaser;
    public int danoDado;
    void Start()
    {
        
    }
    void Update()
    {
        MovimentarLaser();
    }

    private void MovimentarLaser()
    {
        transform.Translate(Vector3.right * velocidadeLaser * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<VidaNave>().DanoNave(danoDado);
            Destroy(this.gameObject);
        }
    }
}

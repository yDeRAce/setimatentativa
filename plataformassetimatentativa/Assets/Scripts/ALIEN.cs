using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALIEN : MonoBehaviour
{
    public float velocidadeAlien;
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
}

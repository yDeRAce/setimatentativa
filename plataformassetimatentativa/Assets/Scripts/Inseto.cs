using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inseto : MonoBehaviour
{

    public float velocidadeInseto;
    
    void Start()
    {
        MovimentarInseto();
    }

    
    void Update()
    {
        
    }
    
    private void MovimentarInseto()
    {
        transform.Translate(Vector3.down * velocidadeInseto * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioInfinito : MonoBehaviour
{
    public float velocidadeCenario;
    void Start()
    {
        
    }

    void Update()
    {
        MovimentarCenario();
    }

    private void MovimentarCenario()
    {
        Vector2 deslocamentoCenario = new Vector2(Time.time * velocidadeCenario, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamentoCenario;
    }
}

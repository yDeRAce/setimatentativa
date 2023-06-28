using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text pontosAtuais;
    
    public int inimigosDerrotados;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        inimigosDerrotados = 0;
    }
    
    void Update()
    {
        
    }

    public void AumentarPontos(int pontosGanhos)
    {
        inimigosDerrotados += pontosGanhos;
    }
}

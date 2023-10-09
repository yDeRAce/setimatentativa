using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    public GameObject menuPause;
    public GameObject painel;
    public GameObject painelMenuInicial;
    public GameObject painelControles;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void Joga()
    {
        GameManager.Instance.Botoes();
        painel.SetActive(false);
    }

    public void abrircontroles()
    {
        painelMenuInicial.SetActive(false);
        painelControles.SetActive(true);
    }

    public void fecharcontroles()
    {
        painelMenuInicial.SetActive(true);
        painelControles.SetActive(false);
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Sair do Jogo");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        menuPause.gameObject.SetActive(false);
    }
}

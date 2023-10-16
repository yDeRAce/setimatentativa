using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject playerStart;

    public GameObject objetoPlayer;
    public GameObject painelGameOver;
    public GameObject painelVitoria;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject); 
        }
    }

    void Start()
    {
        
    }
    
    public void Botoes()
    {
        SceneManager.LoadScene("Gui");
        SceneManager.LoadSceneAsync("Level", LoadSceneMode.Additive).completed += delegate(AsyncOperation operation)
        {
            playerStart = GameObject.Find("playerStart");
            Instantiate(objetoPlayer, playerStart.transform.position, Quaternion.Euler(0, 0, 0));
        };
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        painelGameOver.SetActive(true);
    }

    public void Vitoria()
    {
        Time.timeScale = 0f;
        painelVitoria.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject creditos;
    
    public void Play(){
        SceneManager.LoadScene("Jogo");
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void Exit(){
        Application.Quit();
    }

    public void Credits(){
        creditos.SetActive(!creditos.activeSelf);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BolaController : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 direcao;
    public int velocidade;


    public int pontosPlayer;
    public int pontosEnemy;
    public Text txtPlayer;
    public Text txtEnemy;

    public GameObject menu;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, 0);
        RestartBola();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            pontosPlayer++;
            txtPlayer.text = Convert.ToString(pontosPlayer);
            transform.position = new Vector2(0, 0);
            RestartBola();
        }
        if(other.CompareTag("Enemy")){
            pontosEnemy++;
            txtEnemy.text = Convert.ToString(pontosEnemy);
            transform.position = new Vector2(0, 0);
            RestartBola();
        }

        if(pontosEnemy >=10 || pontosPlayer >=10){
            menu.GetComponent<MenuController>().GameOver();
        }
    }

    private void RestartBola(){
        System.Random random = new System.Random();
        int x = random.Next(0, 4);

        if(x == 0){
            direcao.x = velocidade;
            direcao.y = velocidade;
        }else{
            if(x == 1){
                direcao.x = -velocidade;
                direcao.y = velocidade;
            }else{
                if(x == 2){
                    direcao.x = velocidade;
                    direcao.y = -velocidade;
                }
                else{
                    direcao.x = -velocidade;
                    direcao.y = -velocidade;
                }
            }
        }

        rb.velocity = direcao;
    }
}
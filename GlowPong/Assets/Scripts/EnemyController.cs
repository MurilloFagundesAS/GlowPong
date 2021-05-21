using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Transform bola;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(transform.position.y >= 4){
            transform.position = new Vector2 (7, 4);
        }
        if(transform.position.y <= -4){
            transform.position = new Vector2 (7, -4);
        }
    }

    private void FixedUpdate() {
        transform.position = new Vector2 (7, bola.position.y * (velocidade / 100));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidadeY;
    public int velocidade;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocidadeY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Vertical") != 0){
            velocidadeY = Input.GetAxisRaw("Vertical") * velocidade;
        }
        else{
            velocidadeY = 0;
        }

        if(transform.position.y >= 4){
            transform.position = new Vector2(-7, 4);
        }
        if(transform.position.y <= -4){
            transform.position = new Vector2(-7, -4);
        }
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(0, velocidadeY);
    }
}

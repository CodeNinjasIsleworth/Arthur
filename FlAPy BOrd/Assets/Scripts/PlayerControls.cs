using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
public GameController gameController;
public float velocity = 5; 
private Rigidbody2D rb;
private float objectHeight; 

    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();
        
        rb = GetComponent<Rigidbody2D>();
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) {
            rb.linearVelocity = Vector2.up * velocity;
        }
    }
// the soup zone :D
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "spike" || collision.gameObject.tag == "Ground") {
            //stop all
            Time.timeScale = 0;
        }
    }


    
   
}

//mcjudge mccourt mclawyers c
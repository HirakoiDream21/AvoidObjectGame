using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(0, rb.velocity.y);
        rb.velocity = new Vector2(0, -10);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log(collision.tag+"が接触しました");
    }
    
    
}

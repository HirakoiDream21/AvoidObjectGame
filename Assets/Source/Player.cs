using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xSpeed;
    private Rigidbody2D rb;
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 1){
            xSpeed -= 1.0f;
            if(xSpeed < 0){
                xSpeed = 0.0f;
            }
        }else if(direction == 2){
            xSpeed += 1.0f;
            if(xSpeed > 0){
                xSpeed = 0.0f;
            }
        }
        
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }

    public void Move(float moveSpeed){
        xSpeed = moveSpeed;
        if(moveSpeed > 0){
            // 右方向
            direction = 1;
        }else if(moveSpeed < 0){
            // 左方向
            direction = 2;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Debug.Log("Enemyに"+collision.tag+"が接触しました");

        if (collision.tag == "Player") {
            SceneManager.LoadScene("GameOver");
        }

        // transformを取得
        Transform myTransform = this.transform;
 
        // 座標を取得
        Vector3 pos = myTransform.position;
        pos.x = Random.Range (1.0f, 60.0f) - 30;
        pos.y = 50;
        myTransform.position = pos;  // 座標を設定

    }
    
    
}

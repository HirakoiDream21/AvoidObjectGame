using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public Player player;
    public float moveSpeed;
    private string buttonTagLeft  = "LeftButton";
    private string buttonTagRight = "RightButton";
    private string tag;
    private bool buttonPush = false;

    // Start is called before the first frame update
    void Start()
    {
        tag = gameObject.tag;
        Debug.Log(tag);
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonPush){
            if(tag == buttonTagLeft){
                player.Move(-moveSpeed);
            }else if(tag == buttonTagRight){
                player.Move(moveSpeed);
            }
        }

    }

    public void DownButton(){
        Debug.Log("button on click");
        buttonPush = true;
    }

    public void UpButton(){
        Debug.Log("button up click");
        buttonPush = false;
    }
}

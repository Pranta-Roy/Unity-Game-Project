using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xSpeed=0.02f;
    public float ySpeed=0.02f;
    // Start is called before the first frame update
     
     public bool isMovingLeft=false;
     public bool isMovingRight=false;
     public bool isMovingUp=false;
     public bool isMovingDown=false;

    // Update is called once per frame
    void Update()
    {
     move();  
    }

    void move(){
        
         if(isMovingRight)
        {
            MoveRight();
        }

        if(isMovingLeft)
        {
            MoveLeft();
        }

        if(isMovingUp)
        {
            MoveUp();
        }

        if(isMovingDown)
        {
            MoveDown();
        }
        
    }
    
    public void TriggerLeft(bool canMove){
      isMovingLeft = canMove;
    }

    public void TriggerRight(bool canMove){
      isMovingRight = canMove;
    }

    public void TriggerUp(bool canMove){
        isMovingUp = canMove;
    }

    public void TriggerDown(bool canMove){
        isMovingDown = canMove;
    }
    public void MoveLeft()
    {
       transform.position -= new Vector3(xSpeed,0,0); 
    }
    public void MoveRight()
    {
       transform.position += new Vector3(xSpeed,0,0); 
    }
    public void MoveUp()
    {
        transform.position += new Vector3(0,ySpeed,0);
    }
    public void MoveDown()
    {
        transform.position -= new Vector3(0,ySpeed,0);
    }
}

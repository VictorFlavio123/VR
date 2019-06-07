using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    
    public bool pointIsEnter = false;
    
    public void PlayerMove()
    {
        if(pointIsEnter == false)
        {
            pointIsEnter = true;            
        }
        else if(pointIsEnter == true)
        {
            pointIsEnter = false;
        }
        //player.transform.position +=
    }
	
}

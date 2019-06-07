using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public bool isElevator = false;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ElevatorDetectEnter()
    {
        if (isElevator == false)
        {
            isElevator = true;
        }
        else if (isElevator == true)
        {
            isElevator = false;
        }
        //player.transform.position +=
    }

    public void ElevatorDetectDown()
    {
    }
}

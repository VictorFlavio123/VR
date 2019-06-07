using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour {

    public GameObject plane;
    public float elevatorSpeed;
    public GameObject elevator;
    public bool isUp = false, isDown = true;
    public float x = (float)-36.5, y = (float)45.5, z = (float)48.8;
    public Vector3 newpos;
    public Arrow arrow;
    public Player player;
    // Use this for initialization
    void Start () {
        newpos = new Vector3(x, y, z);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(isUp == true)
        {
            
            elevator.transform.position = Vector3.MoveTowards(elevator.transform.position, newpos, elevatorSpeed);
            if(elevator.transform.position == newpos)
            {
                isUp = false;
                //arrow.gameObject.SetActive(true);
                //player.transform.parent = null;
            }
            
        }
	}

    public void UPfunction()
    {
        isUp = true;        
    }

    public void DOWNfunction()
    {
        
    }
}

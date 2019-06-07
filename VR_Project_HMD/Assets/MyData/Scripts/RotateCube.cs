using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

    public float spin_force;
    public bool isBox = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        //transform.Rotate(0, spin_force * Time.deltaTime, 0);
		
	}

    public void ChangeSpin()
    {
        if (isBox == false)
        {
            isBox = true;
        }
        else if (isBox == true)
        {
            isBox = false;
        }
        //spin_force = -spin_force;
    }
}

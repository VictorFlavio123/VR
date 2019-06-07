using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNo : MonoBehaviour {

    public bool yes = false;
    public Player player;
    public Arrow arrow;
    public YesNo yesclass, noclass;
    public Elevator elevator;
    public GameObject up, down;
    public Elevator elevator2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void YesOrNoFunction()
    {
        yes = true;
        yesclass.transform.gameObject.SetActive(false);
        noclass.transform.gameObject.SetActive(false);
        float x = (float)6.704, y = (float)3, z = (float)-30.303;
        Vector3 newpos = new Vector3(x, y, z);
        player.transform.position = newpos;
        yesclass.transform.GetComponent<BoxCollider>().enabled = !yesclass.transform.GetComponent<BoxCollider>().enabled;
        noclass.transform.GetComponent<BoxCollider>().enabled = !noclass.transform.GetComponent<BoxCollider>().enabled;
        player.transform.parent = elevator2.transform;

    }

    public void NoFunction()
    {
        yes = false;
        elevator.transform.GetComponent<BoxCollider>().enabled = !elevator.transform.GetComponent<BoxCollider>().enabled;
        yesclass.transform.gameObject.SetActive(false);
        noclass.transform.gameObject.SetActive(false);
        arrow.gameObject.SetActive(true);
        float x = (float)6.68, y = (float)3, z = (float)-5.59;
        Vector3 newpos = new Vector3(x, y, z);
        player.transform.position = newpos;
        player.isInElevator = false;
    }
}

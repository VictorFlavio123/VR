using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutPutScript : MonoBehaviour {

    public Player player;
    public Arrow arrow;
    public Lightsaber lightsaber;
    public GameObject plane;

	// Use this for initialization
	void Start () {
		
	}
	
    public void LookAtOut()
    {
        float x = (float)plane.transform.position.x, y = (float)13.49, z = (float)plane.transform.position.z;
        Vector3 newpos = new Vector3(x, y, z);
        player.transform.parent = null;
        player.transform.position = newpos;

        arrow.transform.gameObject.SetActive(true);
        lightsaber.transform.parent = transform;
        lightsaber.transform.gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}

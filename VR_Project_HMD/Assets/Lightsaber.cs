using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour {

    public bool wasTaked = false;
    public Player player;
  //  public Transform targer;

  //  public bool followX;
  //  public bool followY;
  //  public bool followZ;

    public BagMovement bagMovement;

    // Use this for initialization
    void Start () {
		
	}

    public void LightsaberFunction()
    {
        if (wasTaked == false && player.hasAObject == false)
        {
            transform.parent = bagMovement.transform;
            Vector3 newPos = new Vector3(0, -1, 0);
            transform.localPosition = newPos;
            wasTaked = true;
            player.hasAObject = true;
            //followY = true;
            //transform.gameObject.SetActive(false);
            //GetComponent<Rigidbody>().useGravity = false;
            
        }
        else if(wasTaked == false && player.hasAObject == true)
        {
            Debug.Log("You can not take this object");
        }
        else if (wasTaked == true && player.hasAObject == false)
        {
            Debug.Log("You can not take this object");
        }
        else
        {
            player.hasAObject = false;
            transform.parent = null;
            wasTaked = false;
            //GetComponent<Rigidbody>().useGravity = true;
            //followY = false;
        }
        //player.transform.position +=
    }

    // Update is called once per frame
   /* void LateUpdate ()
    {
        Vector3 __rot = transform.localRotation.eulerAngles;
        Vector3 __tar = targer.localRotation.eulerAngles;

        if (followX)
            __rot.x = __tar.x;
        if (followY)
            __rot.y = __tar.y;
        if (followZ)
            __rot.z = __tar.z;
        transform.localRotation = Quaternion.Euler(__rot);
    }*/
}

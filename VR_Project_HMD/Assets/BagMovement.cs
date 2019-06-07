using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagMovement : MonoBehaviour {

    public Transform targer;

    public bool followX;
    public bool followY;
    public bool followZ;
    public Lightsaber lightsaber;

    // Update is called once per frame
    void LateUpdate()
    {
        if(lightsaber.wasTaked == true)
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
        }
        
    }
}

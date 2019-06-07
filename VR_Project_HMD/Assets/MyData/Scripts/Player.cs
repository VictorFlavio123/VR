using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Camera camera;
    public Arrow arrow;
    public float moveSpeed = 10f;
    public Rigidbody rigidbody;
    private CharacterController cc;
    public Elevator elevator, elevator2;
    public GameObject elevatorobject;
    public RotateCube box;
    public YesNo yes, no;
    public bool isInElevator = false;
    public bool hasAObject = false;
    // Use this for initialization
    void Awake ()
    {
        // rigidbody.freezeRotation = true;
        //rigidbody.useGravity = false;
        //camera = Camera.main;
        //arrow = GetComponent<Arrow>() as Arrow;

    }

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update ()
    {
        float dist = Vector3.Distance(elevatorobject.transform.position, transform.position);
        //Debug.Log(dist < 2.5 && elevator.isElevator == true);
        if(dist <= 2.5 && elevator.isElevator == true && isInElevator == false)
        {
            isInElevator = true;
            float x = (float)6.011321f, y = (float)2.86f, z = (float)-27.33891f;
            Vector3 newpos = new Vector3(x, y, z);
            arrow.pointIsEnter = false;
            arrow.gameObject.SetActive(false);
            transform.position = newpos;
            elevator2.transform.GetComponent<BoxCollider>().enabled = !elevator2.transform.GetComponent<BoxCollider>().enabled;
            yes.transform.gameObject.SetActive(true);
            yes.transform.GetComponent<BoxCollider>().enabled = !yes.transform.GetComponent<BoxCollider>().enabled;
            no.transform.gameObject.SetActive(true);
            no.transform.GetComponent<BoxCollider>().enabled = !no.transform.GetComponent<BoxCollider>().enabled;

        }
        float disttobox = Vector3.Distance(box.transform.position, transform.position);
        //Debug.Log(dist < 2.5 && elevator.isElevator == true);
        Debug.Log(disttobox + "distance to box " + box.isBox);
        if (disttobox <= 3.5 && box.isBox == true)
        {
            arrow.pointIsEnter = false;
        }
        //transform.rotation = Quaternion.Euler(0.0f, 0.0f, camera.transform.rotation.y * -1.0f);
        if (arrow.pointIsEnter == true)
        {
            //transform.Translate(camera.transform.forward * Time.deltaTime * moveSpeed, Space.World);
            /*Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            targetVelocity = transform.TransformDirection(targetVelocity);
            targetVelocity *= moveSpeed;

            // Apply a force that attempts to reach our target velocity
            Vector3 velocity = rigidbody.velocity;
            Vector3 velocityChange = (targetVelocity - velocity);
            velocityChange.x = Mathf.Clamp(velocityChange.x, -moveSpeed, moveSpeed);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -moveSpeed, moveSpeed);
            velocityChange.y = 0;
            rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);*/
            Vector3 forward = camera.transform.TransformDirection(Vector3.forward);
            //Vector3 arrowRotation = new Vector3();
            
            //arrow.transform.position = forward;

            cc.SimpleMove(forward * moveSpeed);
        }
    }
}

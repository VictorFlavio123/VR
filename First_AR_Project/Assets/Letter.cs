using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour {
    public GameController gameController;
    public Collider esq, dir;
    public GameObject objEsq, objDir;
    public bool foiAtivada = false;

	// Use this for initialization
	void Start ()
    {
        if (transform.name == "V")
        {
            dir = transform.GetChild(1).GetComponent<BoxCollider>();
            foiAtivada = true;
            gameController.novasLetras.Add(this);
        }
        else if (transform.name == "I")
        {
            esq = transform.GetChild(1).GetComponent<BoxCollider>();
            dir = transform.GetChild(2).GetComponent<BoxCollider>();
        }
        else if (transform.name == "C")
        {
            esq = transform.GetChild(1).GetComponent<BoxCollider>();
            dir = transform.GetChild(2).GetComponent<BoxCollider>();
        }
        else if (transform.name == "T")
        {
            esq = transform.GetChild(1).GetComponent<BoxCollider>();
            dir = transform.GetChild(2).GetComponent<BoxCollider>();
        }
        else if (transform.name == "O")
        {
            esq = transform.GetChild(1).GetComponent<BoxCollider>();
            dir = transform.GetChild(2).GetComponent<BoxCollider>();
        }
        else if (transform.name == "R")
        {
            esq = transform.GetChild(1).GetComponent<BoxCollider>();
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour {

    public Letter letra;
    private int contador = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (letra.gameController.textoErrado.transform.gameObject.activeSelf)
        {
            contador += 1;
            Debug.Log(contador);
            if (contador == 30)
            {
                letra.gameController.textoErrado.transform.gameObject.SetActive(false);
                contador = 0;
            }
            
        }
	}
    void OnTriggerEnter(Collider col)
    {
        /*Debug.Log(col.gameObject.name.Equals(letra.dir.transform.name));
        if (col.gameObject.name.Equals(letra.dir.transform.name))
        {
            letra.gameController.texto.text = letra.gameController.texto.text + "I";
        }*/
        //Debug.Log(col.gameObject.name + "---" +col.transform.parent.transform.name);
        if(letra.foiAtivada == false)
        {
            if(letra.transform.name == "V")
            {
                Debug.Log("---------------------------------------------------tttttttttttt");
                
            }
            if (letra.transform.name == "I" && letra.foiAtivada == false)
            {
                //Debug.Log(col.transform.parent.transform.name);
                if (col.transform.parent.transform.name == "V")
                {
                    //Debug.Log(col.gameObject.name);
                    if (col.gameObject.name == "CubeDir")
                    {
                        letra.gameController.texto.text = letra.gameController.texto.text + "I";
                        letra.foiAtivada = true;
                        letra.gameController.novasLetras.Add(letra);
                        letra.gameController.body.transform.SetParent(letra.transform, false);
                        Quaternion newRotation = new Quaternion(180, 170, 16, 0);
                        letra.gameController.body.transform.localRotation.Set(0, 0, 0, 0);
                        Vector3 newPos = new Vector3(-0.3f, 0, 0.91f);
                        letra.gameController.body.transform.position.Set(0, 0, 0);
                        letra.gameController.body.transform.GetChild(0).transform.gameObject.SetActive(true);
                    }
                    /*else if(col.gameObject.name != "Quad")
                    {
                        letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                    }*/
                }
                else if(col.transform.parent.transform.name != "I" && col.transform.parent.transform.name != "V")
                {
                    letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Já ativado ou errado!";
                    letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                }
            }
            else if(letra.transform.name == "C" && letra.foiAtivada == false)
            {
                if (col.transform.parent.transform.name == "I")
                {
                    if (col.gameObject.name == "CubeDir")
                    {
                        letra.gameController.texto.text = letra.gameController.texto.text + "C";
                        letra.foiAtivada = true;
                        letra.gameController.novasLetras.Add(letra);
                        letra.gameController.body.transform.SetParent(letra.transform, false);
                        Quaternion newRotation = new Quaternion(180, 170, 16, 0);
                        letra.gameController.body.transform.localRotation.Set(0, 0, 0, 0);
                        Vector3 newPos = new Vector3(-0.3f, 0, 0.91f);
                        letra.gameController.body.transform.position.Set(0, 0, 0);
                        letra.gameController.body.transform.GetChild(1).transform.gameObject.SetActive(true);
                    }
                    else if(col.gameObject.name == "CubeEsq")
                    {
                        letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Lado Errado";
                        letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                    }
                }
                else if (col.transform.parent.transform.name != "C" && col.transform.parent.transform.name != "I")
                {
                    letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Já ativado ou errado!";
                    letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                }
            }
            else if (letra.transform.name == "T" && letra.foiAtivada == false)
            {
                if (col.transform.parent.transform.name == "C")
                {
                    if (col.gameObject.name == "CubeDir")
                    {
                        letra.gameController.texto.text = letra.gameController.texto.text + "T";
                        letra.foiAtivada = true;
                        letra.gameController.novasLetras.Add(letra);
                        letra.gameController.body.transform.SetParent(letra.transform, false);
                        Quaternion newRotation = new Quaternion(180, 170, 16, 0);
                        letra.gameController.body.transform.localRotation.Set(0, 0, 0, 0);
                        Vector3 newPos = new Vector3(-0.3f, 0, 0.91f);
                        letra.gameController.body.transform.position.Set(0, 0, 0);
                        letra.gameController.body.transform.GetChild(2).transform.gameObject.SetActive(true);
                    }
                    else if (col.gameObject.name == "CubeEsq")
                    {
                        letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Lado Errado";
                        letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                    }
                }
                else if (col.transform.parent.transform.name != "T" && col.transform.parent.transform.name != "C")
                {
                    letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Já ativado. Errado!";
                    letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                }
            }
            else if (letra.transform.name == "O" && letra.foiAtivada == false)
            {
                if (col.transform.parent.transform.name == "T")
                {
                    if (col.gameObject.name == "CubeDir")
                    {
                        letra.gameController.texto.text = letra.gameController.texto.text + "O";
                        letra.foiAtivada = true;
                        letra.gameController.novasLetras.Add(letra);
                        letra.gameController.body.transform.SetParent(letra.transform, false);
                        //Quaternion newRotation = new Quaternion(180, 170, 16, 0);
                        letra.gameController.body.transform.localRotation.Set(0, 0, 0, 0);
                        //Vector3 newPos = new Vector3(-0.3f, 0, 0.91f);
                        letra.gameController.body.transform.position.Set(0, 0, 0);
                        letra.gameController.body.transform.GetChild(3).transform.gameObject.SetActive(true);
                    }
                    else if (col.gameObject.name == "CubeEsq")
                    {
                        letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Lado Errado";
                        letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                    }
                }
                else if (col.transform.parent.transform.name != "O" && col.transform.parent.transform.name != "T")
                {
                    letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Já ativado. Errado!";
                    letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                }
            }
            else if (letra.transform.name == "R" && letra.foiAtivada == false)
            {
                if (col.transform.parent.transform.name == "O")
                {
                    if (col.gameObject.name == "CubeDir")
                    {
                        letra.gameController.texto.text = letra.gameController.texto.text + "R";
                        letra.foiAtivada = true;
                        letra.gameController.novasLetras.Add(letra);
                        letra.gameController.body.transform.SetParent(letra.transform, false);
                        Quaternion newRotation = new Quaternion(180, 170, 16, 0);
                        letra.gameController.body.transform.localRotation.Set(0, 0, 0, 0);
                        Vector3 newPos = new Vector3(-0.3f, 0, 0.91f);
                        letra.gameController.body.transform.position.Set(0, 0, 0);
                        letra.gameController.body.transform.GetChild(4).transform.gameObject.SetActive(true);
                    }
                    else if (col.gameObject.name == "CubeEsq")
                    {
                        letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Lado Errado";
                        letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                    }
                }
                else if (col.transform.parent.transform.name != "R" && col.transform.parent.transform.name != "O")
                {
                    letra.gameController.textoErrado.transform.GetChild(0).GetComponent<Text>().text = "Já ativado. Errado!";
                    letra.gameController.textoErrado.transform.gameObject.SetActive(true);
                }
            }
        }        
    }
}

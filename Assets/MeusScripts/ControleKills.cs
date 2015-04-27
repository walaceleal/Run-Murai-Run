using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControleKills : MonoBehaviour
{

    public Text marcador;
    int cont = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void Incrementa()
    {
        cont = cont + 1;
        marcador.text = "Mortes: " + cont;
    }
}

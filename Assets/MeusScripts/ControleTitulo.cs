using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControleTitulo : MonoBehaviour {
    
    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void Touch()
    {
        //Application.LoadLevel("GuiPrototipo");
        Application.LoadLevel("Jogo");
    }
}

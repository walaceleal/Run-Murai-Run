using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControleTempo : MonoBehaviour {
    public Text marcador;

	// Use this for initialization
	void Start () {
        marcador.text = "Tempo: 0";
	}
	
	// Update is called once per frame
	void Update () {
        marcador.text = "Tempo: " + (int)Time.realtimeSinceStartup;
	}
}

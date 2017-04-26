using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class controlUI : MonoBehaviour {

	public GameObject panelInicio;
	public GameObject panelPausa;
	public GameObject panelSeleccion;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	public void IniciarJuego() {
		panelInicio.SetActive (false);
	}
		

}

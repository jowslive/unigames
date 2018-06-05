using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosScript : MonoBehaviour {

    public static int pontosValor = 0;
    Text pontos;

	// Use this for initialization
	void Start () {
        pontos = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        pontos.text = "Pontos: " + pontosValor;
	}
}

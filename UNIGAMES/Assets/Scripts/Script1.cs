using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level1");
        PontosScript.pontosValor = 0;
    }

}

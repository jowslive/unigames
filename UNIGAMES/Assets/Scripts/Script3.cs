using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level2");
        PontosScript.pontosValor = 0;
    }
}

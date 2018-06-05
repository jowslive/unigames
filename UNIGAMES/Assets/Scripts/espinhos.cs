using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinhos : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level2");
        PontosScript.pontosValor = 0;
    }
}

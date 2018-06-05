using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMoeda : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        PontosScript.pontosValor += 10;
        Destroy(gameObject);
    }
}

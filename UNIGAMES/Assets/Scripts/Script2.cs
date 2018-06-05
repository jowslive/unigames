using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level2");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Menu Principal 1");
    }
}

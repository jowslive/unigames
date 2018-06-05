using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDoJogo : MonoBehaviour {

	public void mudarACena (int mudarCena)
    {
        SceneManager.LoadScene(mudarCena);
    }
    public void FecharAplicativo ()
    {
        Application.Quit();
    }
}

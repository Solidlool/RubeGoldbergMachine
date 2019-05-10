using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    public string scenetoload;



    public void Playgame()

	{
        SceneManager.LoadScene(scenetoload);
    }
		

}

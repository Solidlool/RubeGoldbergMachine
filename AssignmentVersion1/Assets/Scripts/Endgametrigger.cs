using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgametrigger : MonoBehaviour
{

    bool gameEnded = false;
    
    public string scenetoload;

    public void OnCollisionEnter(Collision other)
    {


        

        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene(scenetoload);
        }



    }
}
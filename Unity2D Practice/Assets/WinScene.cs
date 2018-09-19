using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour {

    int currentSceneIndex;

    // Update is called once per frame
    void Update () {
 
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadGameScene();
        }
    }

    public void LoadGameScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex - 1);
    }
}

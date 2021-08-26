using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    GameObject sceneToLoad;
    public Scene toLoad;

    private void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
        {
            LoadNewScene();
        }
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene(toLoad.handle);
    }
}

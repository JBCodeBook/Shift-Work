using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager_GoToMenuScene : MonoBehaviour
{
    private GameManager gameManagerMaster;

    private void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.GoToMenuSceneEvent += GoToMenuScene;
    }

    private void OnDisable()
    {
        gameManagerMaster.GoToMenuSceneEvent -= GoToMenuScene;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager>();
    }

    void GoToMenuScene()
    {
        Debug.Log("Loading Title Scree");
        SceneManager.LoadScene(0);
    }
}

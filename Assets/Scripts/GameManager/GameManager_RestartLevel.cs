using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager_RestartLevel : MonoBehaviour
{
    private GameManager gameManagerMaster;

    private void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.RestartLevelEvent += RestartLevel;
    }

    private void OnDisable()
    {
        gameManagerMaster.RestartLevelEvent -= RestartLevel;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager>();
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_GameOver : MonoBehaviour
{
    private GameManager gameManagerMaster;
    public GameObject panelGameOver;

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.GameOverEvent += TurnOnGameOverPanel;
    }

    void OnDisable()
    {
        gameManagerMaster.GameOverEvent -= TurnOnGameOverPanel;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager>();
    }

    void TurnOnGameOverPanel()
    {
        if(panelGameOver != null)
        {
            panelGameOver.SetActive(true);
        }
    }
}


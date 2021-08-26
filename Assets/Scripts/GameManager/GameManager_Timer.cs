using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Timer : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject Timer;

    // Start is called before the first frame update
    void Start()
    {
        ToggleTimer();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForTimerToggleRequest();
    }

    void OnEnable()
    {
        SetinitialReferences();
        gameManager.GameOverEvent += ToggleTimer;
    }

    void OnDisable()
    {
        gameManager.GameOverEvent -= ToggleTimer;  // Change this so that you return to the title screen on game over
    }

    void SetinitialReferences()
    {
        gameManager = GetComponent<GameManager>();
    }

    void CheckForTimerToggleRequest()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !gameManager.isGameOver)
        {
            ToggleTimer();
        }
    }

    void ToggleTimer()
    {
        if (Timer != null)
        {
            Timer.SetActive(!Timer.activeSelf);
            gameManager.isTimerOn = !gameManager.isTimerOn;
            gameManager.CallEventTimer();
        }
        else
        {
            Debug.LogWarning("You need to assign a UI GameObject to the Toggle timer script in the inspector.");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ToggleMenu : MonoBehaviour
{

    private GameManager gameManager;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        ToggleMenu();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForMenuToggleRequest();
    }

    void OnEnable()
    {
        SetinitialReferences();
        gameManager.GameOverEvent += ToggleMenu;
    }

    void OnDisable()
    {
        gameManager.GameOverEvent -= ToggleMenu;  // Change this so that you return to the title screen on game over
    }

    void SetinitialReferences()
    {
        gameManager = GetComponent<GameManager>();
    }

    void CheckForMenuToggleRequest()
    {
        if(Input.GetKeyUp(KeyCode.Escape)&& !gameManager.isGameOver)
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        if(menu != null)
        {
            menu.SetActive(!menu.activeSelf);
            gameManager.isMenuOn = !gameManager.isMenuOn;
            gameManager.CallEventMenuToggle();
        }
        else
        {
            Debug.LogWarning("You need to assign a UI GameObject to the Toggle Menu script in the inspector.");
        }
    }
}

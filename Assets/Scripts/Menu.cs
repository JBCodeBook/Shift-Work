using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NewGameButton(string newGame)
    {
        SceneManager.LoadScene(newGame);
    }

    public void Loadmenu(string menu)
    {
        SceneManager.LoadScene(menu);
    }

    public void ExitGameBtn()
    {
        Debug.Log("EXIT GAME");
        Application.Quit();
    }
}

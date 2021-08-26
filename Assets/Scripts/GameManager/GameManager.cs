using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public delegate void GameMangerEventHandler();
    public event GameMangerEventHandler MenuToggleEvent;
    public event GameMangerEventHandler InventoryUIToggleEvent;
    public event GameMangerEventHandler RestartLevelEvent;
    public event GameMangerEventHandler GoToMenuSceneEvent;
    public event GameMangerEventHandler GameOverEvent;
    public event GameMangerEventHandler TimerToggleEvent;
    public event GameMangerEventHandler SecondFloorEvent;

    public bool isGameOver;
    public bool isInventoryUIOn;
    public bool isMenuOn;
    public bool isTimerOn;

    public void CallEventMenuToggle()
    {
        if (MenuToggleEvent != null)
        {
            MenuToggleEvent();
        }
    }

    public void CallEventTimer()
    {
        if (TimerToggleEvent != null)
        {
            TimerToggleEvent();
        }
    }

    public void CallEventInventoryUIToggle()
    {
        if (InventoryUIToggleEvent != null)
        {
            InventoryUIToggleEvent();
        }
    }

        public void CallEventRestartLevel()
        {
            if (RestartLevelEvent != null)
            {
                RestartLevelEvent();
            }
        }

        public void CallEventGoToMenuScene()
        {
        
        Debug.Log("Calling Menu"); 
            if (GoToMenuSceneEvent != null)
            {
                GoToMenuSceneEvent();
            }
        }

        public void CallEventGameOver()
        {
            if (GameOverEvent != null)
            {
                isGameOver = true;
                GameOverEvent();
            }
        }

    public void CallEventSecondFloor()
    {
        if (SecondFloorEvent != null)
        {
            SecondFloorEvent();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ToggleCursor : MonoBehaviour
{
    private GameManager gameMananagerMaster;
    private bool isCursorLocked = true;

    void OnEnable()
    {
        SetInitialReferences();
        gameMananagerMaster.MenuToggleEvent += ToggleCursorState;
        // gameMananagerMaster.InventoryUIToggleEvent -= ToggleCursorState;

    }

    void OnDisable()
    {
        gameMananagerMaster.MenuToggleEvent -= ToggleCursorState;
        // gameMananagerMaster.InventoryUIToggleEvent -= ToggleCursorState;
    }

    void Update()
    {
        CheckIfCursorShouldBeLcoked();
    }

    void SetInitialReferences()
    {
        gameMananagerMaster = GetComponent<GameManager>();
    }

    void ToggleCursorState()
    {
        isCursorLocked = !isCursorLocked;
    }

    void CheckIfCursorShouldBeLcoked()
    {
        if (isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}

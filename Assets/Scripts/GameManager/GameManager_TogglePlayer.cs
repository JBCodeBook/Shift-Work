using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager_TogglePlayer : MonoBehaviour
{
    public CharacterController playerController;
    private GameManager gameManagerMaster;

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.MenuToggleEvent += TogglePlayerController;
        //gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
    }

    void OnDisable()
    {
        gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
        //gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager>();
    }

    void TogglePlayerController()
    {
        if (playerController != null)
        {
            playerController.enabled = !playerController.enabled;
        }
    }
}

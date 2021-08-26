using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ToggleinventoryUI : MonoBehaviour
{
    [Tooltip("Does this game mode have an inventory? Set to true if that is the case")]
    public bool hasInventory;
    public GameObject inventoryUI;
    public string toggleInventoryButton;
    private GameManager gameManagerMaster;

    // Start is called before the first frame update
    void Start()
    {
        SetInitialReferences();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForInventoryUIToggleRequest();
    }


    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager>();

        if(toggleInventoryButton == "")
        {
            Debug.LogWarning("Please Type in the name of hte button used to toggle the inventory in Game manager" +
                "GameManagerToggleUI");
            this.enabled = false;
        }
    }

    void CheckForInventoryUIToggleRequest()
    {
        if(Input.GetButtonUp(toggleInventoryButton) && !gameManagerMaster.isMenuOn &&
            !gameManagerMaster.isGameOver && hasInventory)
        {
            ToggleInventoryUI();
        }
    }

    void ToggleInventoryUI()
    {
        if(inventoryUI != null)
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            gameManagerMaster.isInventoryUIOn = !gameManagerMaster.isInventoryUIOn;
            gameManagerMaster.CallEventInventoryUIToggle();
        }
    }
}

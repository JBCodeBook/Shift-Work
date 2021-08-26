using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    private bool isTop = false;
    private bool isBottom = false;

    public GameObject Floor1;
    public GameObject Floor2;
    public GameObject Floor3;
    public GameObject Floor4;
    public GameObject Floor5;
    public GameObject Floor6;

    [SerializeField] public GameObject Elevator;
    public bool canMove = true;
    public bool hasCoroutine = false;

    
    public void Switch()
    {
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isTop = Elevator.GetComponent<EventTrigger>().isTop();
        isBottom = Elevator.GetComponent<EventTrigger>().isBottom();
        hasCoroutine = Elevator.GetComponent<MoveObject>().isButtonLocked();

        
        if (this.name == "ButtonFloor1")
        {
            if (!hasCoroutine && !isTop)
            {                
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor1);
                Floor1.SetActive(true);
                Floor2.SetActive(true);
                Floor3.SetActive(false);
                Floor4.SetActive(false);
                Floor5.SetActive(false);
                Floor6.SetActive(false);

            }
        }

        if (this.name == "ButtonFloor2")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor2);
                Floor1.SetActive(false);
                Floor2.SetActive(true);
                Floor3.SetActive(true);
                Floor4.SetActive(false);
                Floor5.SetActive(false);
                Floor6.SetActive(false);
            }
        }

        if (this.name == "ButtonFloor3")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor3);
                Floor1.SetActive(false);
                Floor2.SetActive(false);
                Floor3.SetActive(true);
                Floor4.SetActive(true);
                Floor5.SetActive(false);
                Floor6.SetActive(false);
            }
        }

        if (this.name == "ButtonFloor4")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor4);
                Floor1.SetActive(false);
                Floor2.SetActive(false);
                Floor3.SetActive(false);
                Floor4.SetActive(true);
                Floor5.SetActive(true);
                Floor6.SetActive(false);
            }
        }

        if (this.name == "ButtonFloor5")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor5);
                Floor1.SetActive(false);
                Floor2.SetActive(false);
                Floor3.SetActive(false);
                Floor4.SetActive(false);
                Floor5.SetActive(true);
                Floor6.SetActive(true);
            }
        }

        if (this.name == "ButtonFloor6")
        {
            if (!hasCoroutine && !isTop)
            {
                this.GetComponentInParent<ElevatorPanelControl>().MoveUp(this.GetComponentInParent<ElevatorPanelControl>().Floor6);
                Floor1.SetActive(false);
                Floor2.SetActive(false);
                Floor3.SetActive(false);
                Floor4.SetActive(false);
                Floor5.SetActive(true);
                Floor6.SetActive(true);
            }
        }

    }

    public void interact()
    {
        Switch();
    }
}

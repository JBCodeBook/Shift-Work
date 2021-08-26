using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SecondFloor : MonoBehaviour
{
    public Text scoreDisplay;
    private int Score = 0;
    private int MAXSCORE = 5;
    public GameObject button;
    public GameObject elevator;
    public GameObject floorTrigger;

    public delegate void lvlComplete();
    public static event lvlComplete OnComplete;

    private void Start()
    {
        button.GetComponent<ElevatorDoorController>().isPowered = false;
        scoreDisplay.enabled = true;
    }
    private void OnEnable()
    {
        PaperShredder.OnShred += shredder;
        EnterFloor.OnEnter += StartFloor;
    }

    private void OnDisable()
    {
        PaperShredder.OnShred -= shredder;
    }

    void StartFloor()
    {
        button.GetComponent<SecondFloorPanel>().turnOff();
        Debug.Log("Starting Level/closing doors");
        StartCoroutine(elevator.GetComponent<ElevatorDoors>().CloseElevator());
    }
    void shredder()
    {
        Score += 1;
        scoreDisplay.text = Score.ToString() + "/" + MAXSCORE;

        if(Score >= MAXSCORE)
        {
            winCondition();
        }
    }

    void winCondition()
    {
        button.GetComponent<ElevatorDoorController>().isPowered = true;
        OnComplete();
        Destroy(floorTrigger);
    }
}
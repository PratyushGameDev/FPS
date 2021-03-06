using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChooser : MonoBehaviour
{
    //public GameObject opposingPillsButton;
    //public GameObject pillArenaButton;
    //public GameObject pillarsButton;
    //public GameObject trialsButton;
    //public GameObject underGroundButton;


    public int mapChosen = 0;
    [SerializeField] GameObject mapChooseContinueButton;
    public string mapName;

    public void OpposingPills()
    {
        mapChosen = 1;
        mapName = "OpposingPills";
        mapChooseContinueButton.SetActive(true);
    }
    public void PillArena()
    {
        mapChosen = 2;
        mapName = "PillArena";
        mapChooseContinueButton.SetActive(true);
    }
    public void Pillars()
    {
        mapChosen = 3;
        mapName = "Pill-ArsOfMadness";
        mapChooseContinueButton.SetActive(true);
    }
    public void Trials()
    {
        mapChosen = 4;
        mapName = "PillTrials";
        mapChooseContinueButton.SetActive(true);
    }
    public void UnderGround()
    {
        mapChosen = 5;
        mapName = "UndergroundPill-Amid";
        mapChooseContinueButton.SetActive(true);
    }
}

﻿using Assets.Scripts;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    [SerializeField]
    private int _tileCounter;
    public LessonEventController controller;
    public Animator Panel_LessonEnd;
    public ScreenManager ScreenManager;
    
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag(Tags.LessonController).GetComponent<LessonEventController>();
        controller.TilePlaced += this.CheckTilePosition;
    }
    void Update()
    {
        if (_tileCounter >= 4)
            this.Invoke("OnLessonEnd", 1); 
    }

    void CheckTilePosition(Tile tile, GameObject target)
    {
        switch (tile.name)
        {
            case "Verdichter":
                {
                    if (target.name == "Anchor_1")
                    {
                        tile.isInRightPlace = true;
                        _tileCounter++;
                    }
                    else tile.isInRightPlace = false;
                }
                break;
            case "Drosselorgan":
                {
                    if (target.name == "Anchor_3")
                    {
                        tile.isInRightPlace = true;
                        _tileCounter++;
                    }
                    else tile.isInRightPlace = false;
                }
                break;
            case "Verdampfer":
                {
                    if (target.name == "Anchor_4")
                    {
                        tile.isInRightPlace = true;
                        _tileCounter++;
                    }
                    else tile.isInRightPlace = false;
                }
                break;
            case "Verfluessiger":
                {
                    if (target.name == "Anchor_2")
                    {
                        tile.isInRightPlace = true;
                        _tileCounter++;
                    }
                    else tile.isInRightPlace = false;
                }
                break;
        }
    }

    public void DisableIntroduction()
    {
    }

    private void OnLessonEnd()
    {
        ScreenManager.OpenPanel(Panel_LessonEnd);
    }

    public void OnClickButtonBack()
    {
        Application.LoadLevel("Main");
    }
}
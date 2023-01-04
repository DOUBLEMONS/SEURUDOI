using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Image Touch_To_Start;
    public Image Achievement;
    public Image Leader_Board;
    public Image Play;
    public Image Setting;

    public GameObject GuideBoard;

    void Update()
    {
        if(GuideBoard.activeSelf == false)
        {
            Title_Button_Activation();
        }
        else
        {
            Title_Button_Disabled();    
        }
    }

    public void Title_Button_Activation()
    {
        Touch_To_Start.raycastTarget = true;
        Achievement.raycastTarget = true;
        Leader_Board.raycastTarget = true;
        Play.raycastTarget = true;
        Setting.raycastTarget = true;
    }

    public void Title_Button_Disabled()
    {
        Touch_To_Start.raycastTarget = false;
        Achievement.raycastTarget = false;
        Leader_Board.raycastTarget = false;
        Play.raycastTarget = false;
        Setting.raycastTarget = false;
    }
}

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_Activation()
    {
        Touch_To_Start.raycastTarget = true;
        Achievement.raycastTarget = true;
        Leader_Board.raycastTarget = true;
        Play.raycastTarget = true;
        Setting.raycastTarget = true;
    }

    public void Button_Disabled()
    {
        Touch_To_Start.raycastTarget = false;
        Achievement.raycastTarget = false;
        Leader_Board.raycastTarget = false;
        Play.raycastTarget = false;
        Setting.raycastTarget = false;
    }
}

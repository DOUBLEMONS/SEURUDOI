using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Screen_Play : MonoBehaviour
{
    public string log;
    public bool play = false;

    public GameObject GuideBoard;
    public GameObject LogoutBoard;
    public Image Play_Button;

    public void Play()
    {
        if(play == true)
        {
            GuideBoard.SetActive(true);
            LogoutBoard.SetActive(true);
        }
        else if(play == false)
        {
            Login();
        }

        Play_Button.raycastTarget = false;
    }

    public void Login()
    {
        play = true;

        GPGSBinder.Inst.Login((success, localUser) =>
        log = $"{success}, {localUser.userName}, {localUser.id}, {localUser.state}, {localUser.underage}");

        Debug.Log(log);

        Play_Button.raycastTarget = false;

        Invoke("Return", 0.5f);
    }

    public void Logout()
    {
        play = false;

        GPGSBinder.Inst.Logout();

        Debug.Log(log);

        Play_Button.raycastTarget = false;

        Invoke("Return", 0.5f);
    }

    private void Return()
    {
        GuideBoard.SetActive(false);
        LogoutBoard.SetActive(false);

        Play_Button.raycastTarget = true;
    }
}
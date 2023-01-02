using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Play : MonoBehaviour
{
    public string log;
    public bool play = false;

    public GameObject GuideBoard;
    public GameObject LogoutBoard;

    public void Play()
    {
        if(play == true)
        {
            GuideBoard.SetActive(true);
            LogoutBoard.SetActive(true);
        }
        else if(play == false)
        {
            play = true;
        }
    }

    public void Login()
    {
        play = true;

        GPGSBinder.Inst.Login((success, localUser) =>
        log = $"{success}, {localUser.userName}, {localUser.id}, {localUser.state}, {localUser.underage}");

        Debug.Log(log);

        Invoke("Reset", 1);
    }

    public void Logout()
    {
        play = false;

        GPGSBinder.Inst.Logout();

        Debug.Log(log);

        Invoke("Reset", 1);
    }

    private void Reset()
    {
        GuideBoard.SetActive(false);
        LogoutBoard.SetActive(false);
    }
}
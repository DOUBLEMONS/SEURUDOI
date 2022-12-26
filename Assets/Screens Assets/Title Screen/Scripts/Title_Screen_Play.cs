using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Play : MonoBehaviour
{
    string log;
    bool play = false;

    public void Play()
    {
        if(play == true)
        {
            play = false;

            GPGSBinder.Inst.Logout();

            Debug.Log(log);
        }
        else 
        {
            play = true;

            GPGSBinder.Inst.Login((success, localUser) =>
            log = $"{success}, {localUser.userName}, {localUser.id}, {localUser.state}, {localUser.underage}");

            Debug.Log(log);
        }
    }
}

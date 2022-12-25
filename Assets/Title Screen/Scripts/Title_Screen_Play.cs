using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Play : MonoBehaviour
{
    string log;
    bool play = false;

    public void Login()
    {
        if(play == true)
        {
            GPGSBinder.Inst.Logout();

            Debug.Log(log);

            play = false;
        }
        else 
        {
            GPGSBinder.Inst.Login((success, localUser) =>
            log = $"{success}, {localUser.userName}, {localUser.id}, {localUser.state}, {localUser.underage}");

            Debug.Log(log);

            play = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Leaderboard : MonoBehaviour
{
    string log;

    public void Leaderboard()
    {
        GPGSBinder.Inst.ShowAllLeaderboardUI();

        Debug.Log(log);
    }
}

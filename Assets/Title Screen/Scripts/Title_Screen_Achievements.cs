using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Achievements : MonoBehaviour
{
    string log;

    public void Achievement()
    {
        GPGSBinder.Inst.ShowAchievementUI();

        Debug.Log(log);
    }
}

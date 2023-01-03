using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Screen_Settings : MonoBehaviour
{
    public GameObject GuideBoard;
    public GameObject SettingBoard;
    public Image Setting_Button;

    public string log;

    public void Settings()
    {
        GuideBoard.SetActive(true);
        SettingBoard.SetActive(true);

        Setting_Button.raycastTarget = false;
    }

    public void Wait()
    {
        Invoke("Return", 0.5f);
    }

    private void Return()
    {
        GuideBoard.SetActive(false);
        SettingBoard.SetActive(false);

        Setting_Button.raycastTarget = true;
    }

    public void SaveCloud()
    {
        GPGSBinder.Inst.SaveCloud("mysave", "want data", success => log = $"{success}");
        Debug.Log(log);
    }

    public void LoadCloud()
    {
        GPGSBinder.Inst.LoadCloud("mysave", (success, data) => log = $"{success}, {data}");
        Debug.Log(log);
    }

    public void DeleteCloud()
    {
        GPGSBinder.Inst.DeleteCloud("mysave", success => log = $"{success}");
        Debug.Log(log);
    }
}

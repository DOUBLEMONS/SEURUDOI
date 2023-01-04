using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames.BasicApi;
using UnityEditor.Rendering.LookDev;

public class Title_Screen_Settings : MonoBehaviour
{
    public GameObject GuideBoard;
    public GameObject SettingBoard;
    public Image Setting_Button;

    public GameObject SaveBoard;
    public GameObject LoadBoard;
    public GameObject DeleteBoard;

    public string log;

    public void Settings()
    {
        GuideBoard.SetActive(true);
        SettingBoard.SetActive(true);

        Setting_Button.raycastTarget = false;
    }

    public void Wait()
    {
        Invoke("Return", 0.25f);
    }

    private void Return()
    {
        GuideBoard.SetActive(false);
        SettingBoard.SetActive(false);
        SaveBoard.SetActive(false);
        LoadBoard.SetActive(false);
        DeleteBoard.SetActive(false);

        Setting_Button.raycastTarget = true;
    }

    public void Save()
    {
        Invoke("SaveCloud", 0.25f);
    }

    public void SaveCloud()
    {
        GuideBoard.SetActive(true);
        SaveBoard.SetActive(true);

        GuideBoard.GetComponent<GuideBoard_Damping_Move>().PanelDown();
    }

    public void SaveCloudConfirm()
    {
        //GPGSBinder.Inst.SaveCloud("mysave", "want data", success => log = $"{success}");
        Debug.Log("SaveCloud");
    }

    public void Load()
    {
        Invoke("LoadCloud", 0.25f);
    }

    public void LoadCloud()
    {
        GuideBoard.SetActive(true);
        LoadBoard.SetActive(true);

        GuideBoard.GetComponent<GuideBoard_Damping_Move>().PanelDown();
    }

    public void LoadCloudConfirm()
    {
        //GPGSBinder.Inst.LoadCloud("mysave", (success, data) => log = $"{success}, {data}");
        Debug.Log("LoadCloud");
    }

    public void Delete()
    {
        Invoke("DeleteCloud", 0.25f);
    }

    public void DeleteCloud()
    {
        GuideBoard.SetActive(true);
        DeleteBoard.SetActive(true);

        GuideBoard.GetComponent<GuideBoard_Damping_Move>().PanelDown();
    }

    public void DeleteCloudConfirm()
    {
        //GPGSBinder.Inst.DeleteCloud("mysave", success => log = $"{success}");
        Debug.Log("DeleteCloud");
    }

    public void CloudWait()
    {
        Invoke("Return", 0.25f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Services.CloudSave;

public class Title_Screen_Settings : MonoBehaviour
{
    public GameObject GuideBoard;
    public GameObject SettingBoard;
    public Image Setting_Button;

    public GameObject LoadBoard;
    public GameObject DeleteBoard;

    public Image LoadBoard_Button;
    public Image DeleteBoard_Button;

    public string log;

    public void Settings()
    {
        GuideBoard.SetActive(true);
        SettingBoard.SetActive(true);

        Setting_Button.raycastTarget = false;
        LoadBoard_Button.raycastTarget = false;
        DeleteBoard_Button.raycastTarget = false;

        Invoke("ButtonOn", 0.75f);
    }

    private void ButtonOn()
    {
        LoadBoard_Button.raycastTarget = true;
        DeleteBoard_Button.raycastTarget = true;
    }

    public void Wait()
    {
        Invoke("Return", 0.25f);
    }

    private void Return()
    {
        GuideBoard.SetActive(false);
        SettingBoard.SetActive(false);
        LoadBoard.SetActive(false);
        DeleteBoard.SetActive(false);

        Setting_Button.raycastTarget = true;
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

    public void CloudWait()
    {
        Invoke("Return", 0.25f);
    }
}

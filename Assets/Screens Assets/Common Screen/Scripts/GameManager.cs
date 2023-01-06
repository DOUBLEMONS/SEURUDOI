using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("DontDestroyOnLoad")]
    public GameObject GameManagers;
    public GameObject BackGround;
    public Canvas FadeEffect;

    [Header("BackButton")]
    public GameObject GuideBoard;
    public GameObject ExitBoard;
    public GameObject Canvas;

    public bool Back = false;

    //·Î±×ÀÎ
    public GameObject TSP;

    void Awake()
    {
        DontDestroyOnLoad(GameManagers);
        DontDestroyOnLoad(BackGround);
        DontDestroyOnLoad(FadeEffect);
    }

    void Start()
    {
        TSP.GetComponent<Title_Screen_Play>().Login();
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //back button
            if (Input.GetKey(KeyCode.Escape))
            {
                if (Back == false)
                {
                    GuideBoard.SetActive(true);
                    ExitBoard.SetActive(true);
                    GuideBoard.GetComponent<GuideBoard_Damping_Move>().PanelDown();
                }

                Back = true;
            }
        }
    }

    //public void MoveOnWait()
    //{
    //    GuideBoard.GetComponent<GuideBoard_Damping_Move>().PanelUp();
    //    Invoke("MoveOn", 0.25f);
    //}

    //public void MoveOn()
    //{
    //    GuideBoard.SetActive(false);
    //    ExitBoard.SetActive(false);
    //}

    //public void Exit()
    //{

    //}
}

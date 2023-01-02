using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("DontDestroyOnLoad")]
    public GameObject GameManagers;
    public GameObject BackGround;
    public Canvas FadeEffect;
    public GameObject GuideBoard;
    public GameObject ButttonBoard;

    //·Î±×ÀÎ
    public GameObject TSP;

    void Awake()
    {
        DontDestroyOnLoad(GameManagers);
        DontDestroyOnLoad(BackGround);
        DontDestroyOnLoad(FadeEffect);
        DontDestroyOnLoad(GuideBoard);
        DontDestroyOnLoad(ButttonBoard);
    }

    void Start()
    {
        TSP.GetComponent<Title_Screen_Play>().Login();
    }
}

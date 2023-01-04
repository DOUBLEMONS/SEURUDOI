using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("DontDestroyOnLoad")]
    public GameObject GameManagers;
    public GameObject BackGround;
    public Canvas FadeEffect;

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
}

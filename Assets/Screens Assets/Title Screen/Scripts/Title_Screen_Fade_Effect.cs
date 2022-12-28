using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Screen_Fade_Effect : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float FadeTime;
    private Image BackGround;

    public Image Touch_to_start;
    public Image Achievement;
    public Image Current_situation;
    public Image Interlock;
    public Image Setting;

    //로그인
    public GameObject Title_Screen_Play;

    [Header("DontDestroyOnLoad")]
    public GameObject GameManager;
    public GameObject RealBackGround;
    public Canvas FakeBackGround;

    void Awake()
    {
        BackGround = GetComponent<Image>();
        DontDestroyOnLoad(GameManager);
        DontDestroyOnLoad(RealBackGround);
        DontDestroyOnLoad(FakeBackGround);
    }

    void Start()
    {
        // 로그인
        Title_Screen_Play TSP = GameObject.Find("Play_Button").GetComponent<Title_Screen_Play>();

        GPGSBinder.Inst.Login((success, localUser) =>
        TSP.log = $"{success}, {localUser.userName}, {localUser.id}, {localUser.state},{localUser.underage}");

        Debug.Log(TSP.log);

        TSP.play = true;
    }

    /////////////////////////////////////////

    // 다음 장면
    public void Title_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(0);
    }

    /////////////////////////////////////////

    // 다음 장면
    public void Assassination_Select_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(1);
    }

    // 현재 장면
    public void Touch_To_Start()
    {
        StartCoroutine(Fade(0, 1));
        Touch_to_start.raycastTarget = false;
        Achievement.raycastTarget = false;
        Current_situation.raycastTarget = false;
        Interlock.raycastTarget = false;
        Setting.raycastTarget = false;

        Invoke("Assassination_Select_Screen", 2);
    }

    /////////////////////////////////////////

    // 다음 장면
    public void Assassination_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(2);
    }

    /////////////////////////////////////////

    private IEnumerator Fade(float Start, float End)
    {
        float CurrentTime = 0.0f;
        float Percent = 0.0f;

        while(Percent < 1)
        {
            CurrentTime += Time.deltaTime;
            Percent = CurrentTime / FadeTime;

            Color Color = BackGround.color;
            Color.a = Mathf.Lerp(Start, End, Percent);
            BackGround.color = Color;

            yield return null;
        }
    }
}

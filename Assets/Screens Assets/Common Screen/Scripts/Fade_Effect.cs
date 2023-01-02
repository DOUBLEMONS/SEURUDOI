using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade_Effect : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float FadeTime;
    public Image BackGround;

    ////로그인
    //public GameObject Title_Screen_Play;

    void Awake()
    {

    }

    //void Start()
    //{
    //    // 로그인
    //    Title_Screen_Play TSP = GameObject.Find("Play_Button").GetComponent<Title_Screen_Play>();

    //    GPGSBinder.Inst.Login((success, localUser) =>
    //    TSP.log = $"{success}, {localUser.userName}, {localUser.id}, {localUser.state},{localUser.underage}");

    //    Debug.Log(TSP.log);

    //    TSP.play = true;
    //}

    ///////////////////////////////////////////

    // 버튼
    public void Touch_To_Start()
    {
        StartCoroutine(Fade(0, 1));
        Invoke("Select_Screen", 2);
    }

    // 장면
    public void Title_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(0);
    }

    public void Select_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(1);
    }

    public void Himeji_Castle_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(2);
    }

    public void Matsumoto_Castle_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(3);
    }

    public void Nagoya_Castle_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(4);
    }

    public void Osaka_Castle_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(5);
    }

    public void Matsue_Castle_Screen()
    {
        StartCoroutine(Fade(1, 0));
        SceneManager.LoadScene(6);
    }

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

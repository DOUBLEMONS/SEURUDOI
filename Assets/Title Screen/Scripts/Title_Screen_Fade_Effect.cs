using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Title_Screen_Fade_Effect : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float FadeTime;
    private Image BackGround;

    public Image Touch_to_start;
    public Image Achievement;
    public Image Setting;
    public Image Current_situation;
    public Image Interlock;

    void Awake()
    {
        BackGround = GetComponent<Image>();
    }

    public void Fade_In()
    {
        StartCoroutine(Fade(1, 0));

        Invoke("Return", 1);
    }

    public void Return()
    {
        Touch_to_start.raycastTarget = true;
        Achievement.raycastTarget = true;
        Setting.raycastTarget = true;
        Current_situation.raycastTarget = true;
        Interlock.raycastTarget = true;
    }

    public void Fade_Out()
    {
        StartCoroutine(Fade(0, 1));
        Touch_to_start.raycastTarget = false;
        Achievement.raycastTarget = false;
        Setting.raycastTarget = false;
        Current_situation.raycastTarget = false;
        Interlock.raycastTarget = false;

        Invoke("Fade_In", 2);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using DG.Tweening;

public class GuideBoard_Damping_Move : MonoBehaviour
{
    public float FadeTimeDown = 0;
    public float FadeTimeUp = 0;
    public CanvasGroup CanvasGroup;
    public RectTransform RectTransform;

    public void PanelDown()
    {
        CanvasGroup.alpha = 0f;
        RectTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        RectTransform.DOAnchorPos(new Vector2(0f, -20f), FadeTimeDown, false).SetEase(Ease.OutElastic);
        CanvasGroup.DOFade(1, FadeTimeDown);
    }

    public void PanelUp()
    {
        CanvasGroup.alpha = 1f;
        RectTransform.transform.localPosition = new Vector3(0f, -20f, 0f);
        RectTransform.DOAnchorPos(new Vector2(0f, 0f), FadeTimeUp, false).SetEase(Ease.InOutQuint);
        CanvasGroup.DOFade(0, FadeTimeUp);
    }
}


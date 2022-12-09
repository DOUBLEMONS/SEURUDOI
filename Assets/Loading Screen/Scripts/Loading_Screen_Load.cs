using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading_Screen_Load : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider Slider;
    public int ScreenIndex;

    void Start()
    {
        StartCoroutine(LoadAsynchronously(ScreenIndex));
    }

    IEnumerator LoadAsynchronously (int ScreenIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(ScreenIndex);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);

            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Game_Screen_Load : MonoBehaviour
{
    public GameObject Title_Screen;

    // Start is called before the first frame update
    void Start()
    {
        Title_Screen.gameObject.SetActive(true);
    }
}

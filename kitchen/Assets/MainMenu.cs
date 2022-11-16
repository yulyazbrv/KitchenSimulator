using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    bool pressBut;
    bool freeBut;
    public RectTransform slider;
    Vector2 v = new Vector2(-290, -29);
    Vector2 v2 = new Vector2(290, -29);
    public GameObject menubut;

    void Start()
    {
        //v = slider.anchoredPosition;
        slider.anchoredPosition = v;
        Debug.Log(v);

    }
    void Update()
    {
        if (pressBut)
        {
            float x = slider.anchoredPosition.x;
            float y = slider.anchoredPosition.y;
            x += 6;
            slider.anchoredPosition = new Vector2(x, y);
            if (slider.anchoredPosition.x >= v2.x)
            {
                pressBut = false;
                Debug.Log(x);
            }

        }

        if (freeBut)
        {
            float x = slider.anchoredPosition.x;
            float y = slider.anchoredPosition.y;
            x -= 6f;
            slider.anchoredPosition = new Vector2(x, y);
            if (slider.anchoredPosition.x <= v.x)
            {
                freeBut = false;
                Debug.Log(x);

            }
        }
    }
    public void Menu()
    {
        pressBut = true;
    }
    public void MenuShow()
    {
        freeBut = true;
    }
    public void ButMenuHide()
    {
        menubut.SetActive(false); //   Активировать объект, чтобы открыть окно.  
    }
    public void ButMenuShow()
    {
        menubut.SetActive(true); //   Активировать объект, чтобы открыть окно.  
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CloseDuh : MonoBehaviour, IPointerClickHandler
{
    public Animator anim;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.Play("AnimationDuhClose");
    }
}

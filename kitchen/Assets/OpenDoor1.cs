using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenDoor1 : MonoBehaviour, IPointerClickHandler
{

    public Animator anim;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.Play("AnimationDoor1Open");
    }
}

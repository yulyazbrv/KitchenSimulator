using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CloseDoor2 : MonoBehaviour, IPointerClickHandler
{
    public Animator anim;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.Play("AnimationDoor2Close");
    }
}

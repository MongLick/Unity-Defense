using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour,
    IPointerClickHandler, 
    IPointerEnterHandler, 
    IPointerExitHandler, 
    IPointerUpHandler, 
    IPointerDownHandler, 
    IPointerMoveHandler
{
    [SerializeField] Renderer render;
    [SerializeField] Color curColor;
    [SerializeField] Color highlightColor;

    public void OnPointerClick(PointerEventData eventData)
    {
        // 클릭시 반응                
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // 마우스 포인터가 들어오면 반응
        render.material.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // 마우스 포인터가 나가면 반응
        render.material.color = curColor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // 마우스 포인터를 떼면 반응
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 마우스 포인터를 누르면 반응
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // 마우스 포인터를 움직이면 반응
    }
}
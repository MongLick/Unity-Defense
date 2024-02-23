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
        // Ŭ���� ����                
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // ���콺 �����Ͱ� ������ ����
        render.material.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // ���콺 �����Ͱ� ������ ����
        render.material.color = curColor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // ���콺 �����͸� ���� ����
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // ���콺 �����͸� ������ ����
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // ���콺 �����͸� �����̸� ����
    }
}
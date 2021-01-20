using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestDragAndDropRune : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer is down");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Pointer drag started");
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Pointer is dragging");
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Pointer drag ended");
    }

}

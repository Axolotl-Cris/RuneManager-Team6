using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestDragAndDropRune : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;
    
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer is down");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Pointer drag started");
        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Pointer is dragging");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Pointer drag ended");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

}

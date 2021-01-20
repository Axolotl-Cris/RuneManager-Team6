using UnityEngine.EventSystems;
using UnityEngine;

public class TestSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ICON DROP");
    }
}

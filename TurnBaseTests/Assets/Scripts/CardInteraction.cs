using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardInteraction : MonoBehaviour
{
    private Canvas canvas;

    private void Start()
    {
        canvas = transform.root.GetComponent<Canvas>();
    }
    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerEventData = (PointerEventData)data;
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
            pointerEventData.position,
            canvas.worldCamera,
            out position);
        transform.position = canvas.transform.TransformPoint(position);
    }
}

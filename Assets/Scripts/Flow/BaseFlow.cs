using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseFlow : MonoBehaviour
{
    public Tile occupiedTile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (!_dragging)
    //         return;
    //
    //     var mousePosition = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //
    //     transform.position = mousePosition;
    // }

    // public void OnDrag(PointerEventData data)
    // {
    //     Debug.Log($"{data.pressPosition.x} + {data.pressPosition.y}");
    //     float dx = data.pressPosition.x - data.position.x;
    //     float dy = data.pressPosition.y - data.position.y;
    //     if (dx > 1)
    //         FlowManager.Instance.PlaceHead(Colors.RED, Mathf.FloorToInt(dx),0);
    //     else if (dy > 1)
    //         FlowManager.Instance.PlaceHead(Colors.RED, 0,Mathf.FloorToInt(dy));
    // }
    //
    // public void OnEndDrag(PointerEventData data)
    // {
    //     
    //     FlowManager.Instance.PlaceHead(Colors.RED, 3,3);
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
        
        GridManager.Instance.GenerateGrid(5,5);
        FlowManager.Instance.PlaceHead(Colors.RED, 0, 0);
        FlowManager.Instance.PlaceHead(Colors.RED, 4, 4);
        FlowManager.Instance.PlaceHead(Colors.GREEN, 2, 2);
        FlowManager.Instance.PlaceHead(Colors.GREEN, 2, 4);
    }

}

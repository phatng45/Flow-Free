using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

        LevelManager.Instance.LoadLevel("1");
        GridManager.Instance.GenerateGrid();
        
        // TODO: change init logic
        FlowManager.Instance.PlaceHead(Colors.RED, 0, 0);
        FlowManager.Instance.PlaceHead(Colors.RED, 4, 4);
        FlowManager.Instance.PlaceHead(Colors.GREEN, 2, 2);
        FlowManager.Instance.PlaceHead(Colors.GREEN, 2, 4);
    }

}

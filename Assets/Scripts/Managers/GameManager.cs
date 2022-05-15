using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

        FileManager.Instance.LoadLevel("4");
        GridManager.Instance.GenerateLevel();
    }

}

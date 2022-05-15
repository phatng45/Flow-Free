using System;
using Managers;
using UnityEngine;

public class GridManager : MonoBehaviour {
    public static GridManager Instance;

    private                  int       rows, cols;
    [SerializeField] private Tile      tilePrefab;
    [SerializeField] private Transform cam;

    private void Awake() {
        Instance = this;
    }

    public void GenerateLevel() {
        var currentLevel = FileManager.Instance.GetCurrentLevel();
        this.rows  = currentLevel.Length;
        this.cols = currentLevel[0].Length;
        
        for (var x = 0; x < rows; x++)
            for (var y = 0; y < cols; y++) {
                // TODO: change init logic
                var tile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                tile.name = $"Tile {x} {y}";
                
                var isOffset = (x + y) % 2 == 1;
                tile.Init(isOffset);

                if (currentLevel[x][y] != 0) 
                    FlowManager.Instance.PlaceHead(Colors.ColorOrder[currentLevel[x][y] -1],x,y);
            }
        
        cam.transform.position = new Vector3((float)rows / 2 - .5f, (float)cols / 2 - .5f, -10);
    }
}
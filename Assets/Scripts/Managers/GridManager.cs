using System;
using Managers;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;

    private                  int       width, height;
    [SerializeField] private Tile      tilePrefab;
    [SerializeField] private Transform cam;

    private void Awake()
    {
        Instance = this;
    }

    public void GenerateGrid()
    {
        var currentLevel = LevelManager.Instance.GetCurrentLevel();
        this.width  = currentLevel[0].Length;
        this.height = currentLevel.Length;

        for (var x = 0; x < width; x++)
        for (var y = 0; y < height; y++)
        {
            // TODO: change init logic
            var tile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
            tile.name = $"Tile {x} {y}";

            var isOffset = (x + y) % 2 == 1;
            tile.Init(isOffset);
        }

        cam.transform.position = new Vector3((float)width / 2 - .5f, (float)height / 2 - .5f, -10);
    }
}
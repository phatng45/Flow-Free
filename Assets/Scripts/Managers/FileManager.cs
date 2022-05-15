using System;
using System.IO;
using UnityEngine;
using System.Linq;

namespace Managers {
    public class FileManager : MonoBehaviour {
        public static FileManager Instance;
        private       int[][]      currentLevel;

        private void Awake() {
            Instance = this;
        }

        public void LoadLevel(string levelName) {
            //var rawLevelText = Resources.Load<TextAsset>($"{Application.streamingAssetsPath}/Levels/level1");
            var rawLevelText = File.ReadAllText($"{Application.streamingAssetsPath}/Levels/{levelName}.txt");

            currentLevel = rawLevelText.Split(Environment.NewLine).Select(r => r.Split(' ').Select(int.Parse).ToArray())
                .ToArray();

            RotateLevelBy90DegreesClockwise();
        }

        public int[][] GetCurrentLevel() {
            return currentLevel;
        }

        void RotateLevelBy90DegreesClockwise() {
            // this function is purely for development
            // in order to keep the map stay the same as the file
            // with Unity coordinate system.
            // without this function, the map in Unity will be rotated
            // by 90 degrees counter clockwise
            // comparing to the intended map

            var rows = currentLevel.Length;
            var cols = currentLevel[0].Length;

            int temp; // for swapping

            var rotatedCurrentLevel = new int[cols][];
            for (int i = 0; i < cols; ++i)
                rotatedCurrentLevel[i] = new int[rows];
            
            // transpose
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                    rotatedCurrentLevel[j][i] = currentLevel[i][j];
            
            // Debug.Log("transpose");
            // string str;
            // for (int i = 0; i < cols; i++) {
            //     str = "";
            //     for (int j = 0; j < rows; j++)
            //         str += $"{rotatedCurrentLevel[i][j]} ";
            //
            //
            //     Debug.Log(str);
            // }

            // horizontal flip
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows / 2; j++) {
                    temp                                 = rotatedCurrentLevel[i][j];
                    rotatedCurrentLevel[i][j]            = rotatedCurrentLevel[i][rows - j - 1];
                    rotatedCurrentLevel[i][rows - j - 1] = temp;
                }
            
            currentLevel = rotatedCurrentLevel;
        }
    }
}
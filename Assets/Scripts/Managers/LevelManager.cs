using System;
using System.IO;
using UnityEngine;
using System.Linq;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        public static LevelManager Instance;
        private       string[][]   currentLevel;

        private void Awake()
        {
            Instance = this;
        }

        public void LoadLevel(string levelName)
        {
            var rawLevelText = Resources.Load($"{Application.streamingAssetsPath}/Levels/{levelName}") as TextAsset;
            if (rawLevelText == null) return;

            currentLevel = rawLevelText.text.Split(Environment.NewLine).Select(r => r.Split(' ')).ToArray();
        }

        public string[][] GetCurrentLevel()
        {
            return currentLevel;
        }
    }
}
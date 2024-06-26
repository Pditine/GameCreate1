using System;
using System.Collections.Generic;
using PurpleFlowerCore.Utility;
using UnityEngine;

namespace Data
{
    public class DataManager : DdolSingletonMono<DataManager>
    {
        [SerializeField] private List<LevelData> levels;
        [SerializeField]private PassingData passingData;

        // private void Start()
        // {
        //     foreach (var levelData in levels)
        //     {
        //         levelData.personaBest = float.PositiveInfinity;
        //     }
        // }

        public List<LevelData> Levels => levels;

        public PassingData PassingData => passingData;

        public LevelData GetLevelDataByIndex(int index)
        {
            if (index >= levels.Count||index<0) return null;
            return levels[index];
        }
    }
}
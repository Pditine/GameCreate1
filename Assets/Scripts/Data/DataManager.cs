using System.Collections.Generic;
using PurpleFlowerCore.Utility;
using UnityEngine;

namespace Data
{
    public class DataManager : DdolSingletonMono<DataManager>
    {
        [SerializeField] private List<LevelData> levels;
        [SerializeField]private PassingData passingData;
        public List<LevelData> Levels => levels;

        public PassingData PassingData => passingData;

        public LevelData GetLevelDataByIndex(int index)
        {
            return levels[index];
        }
    }
}
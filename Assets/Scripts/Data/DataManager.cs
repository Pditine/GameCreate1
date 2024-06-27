using System;
using System.Collections.Generic;
using PurpleFlowerCore;
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

        protected override void Awake()
        {
            base.Awake();
            if(Instance == this)
                LoadData();
        }
        
        

        public List<LevelData> Levels => levels;

        public PassingData PassingData => passingData;

        public LevelData GetLevelDataByIndex(int index)
        {
            if (index >= levels.Count||index<0) return null;
            return levels[index];
        }
        
        public void LoadData()
        {
            for (int i = 0; i < levels.Count; i++)
            {
                SaveSystem.LoadOverwrite(i.ToString(),levels[i]);
            }

        }

        public void SaveData()
        {
            for (int i = 0; i < levels.Count; i++)
            {
                SaveSystem.Save(i.ToString(),levels[i]);
            }

        }
    }
}
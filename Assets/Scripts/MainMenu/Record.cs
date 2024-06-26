using System.Collections.Generic;
using Data;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class Record : MonoBehaviour
    {
        // [SerializeField] private List<Text> levelNames;
        // [SerializeField] private List<Text> levelPBs;
        // [SerializeField] private List<Text> levelTryTimes;
        [SerializeField] private List<LevelRecordInfo> recordInfos;
        public void Init()
        {
            gameObject.SetActive(true);
            for (int i = 0; i < DataManager.Instance.Levels.Count; i++)
            {
                recordInfos[i].Init(DataManager.Instance.GetLevelDataByIndex(i));
            }
        }
    }
}
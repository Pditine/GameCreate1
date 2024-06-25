using System.Collections.Generic;
using Data;
using UnityEngine;

namespace MainMenu
{
    public class LevelSelection : MonoBehaviour
    {
        [SerializeField]private List<LevelIcon> levelIcons;
        
        public void Init()
        {
            gameObject.SetActive(true);
            for (int i = 0; i < DataManager.Instance.Levels.Count; i++)
            {
                levelIcons[i].Init(!DataManager.Instance.GetLevelDataByIndex(i).isPass);
            }
        }
    }
}
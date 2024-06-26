using Data;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class LevelRecordInfo : MonoBehaviour
    {
        [SerializeField] private Text levelName;
        [SerializeField] private Text levelPB;
        [SerializeField] private Text levelTryTime;

        public void Init(LevelData data)
        {
            levelName.text = data.levelName;
            levelPB.text = $"最好成绩:{data.personaBest:0.00}s";
            levelTryTime.text = $"尝试次数:{data.tryTime}";
        }
        
    }
}
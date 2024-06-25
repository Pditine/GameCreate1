using UnityEngine;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/LevelData",fileName = "LevelData")]
    public class LevelData : ScriptableObject
    {
        public string levelName;
        public float personaBest;
        public int tryTime;
        public bool isPass;
        public int sceneId;
    }
}
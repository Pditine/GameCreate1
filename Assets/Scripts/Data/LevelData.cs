using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/LevelData",fileName = "LevelData")]
    public class LevelData : ScriptableObject
    {
        public string levelName;
        public float personaBest;
        public int tryTime;
        [FormerlySerializedAs("isPass")] public bool canTry;
        public int index;
        public int sceneId;

        public void UpdatePB(float time)
        {
            personaBest = time < personaBest ? time : personaBest;
        }
    }
}
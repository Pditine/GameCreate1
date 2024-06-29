using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/LevelData",fileName = "LevelData")]
    public class LevelData : ScriptableObject
    {
        public string levelName;
        public float personaBest = float.PositiveInfinity;
        public int tryTime;
        public bool canTry;
        public int index;
        public int sceneId;

        public void UpdatePB(float time)
        {
            personaBest = time < personaBest ? time : personaBest;
        }
    }
}
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/PassingData",fileName = "PassingData")]
    public class PassingData : ScriptableObject
    {
        public LevelData CurrentLevel;
        
    }
}

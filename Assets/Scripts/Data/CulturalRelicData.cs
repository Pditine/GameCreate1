using UnityEngine;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/CulturalRelicData",fileName = "CulturalRelicData")]
    public class CulturalRelicData : ScriptableObject
    {
        public string culturalRelicName;
        public string introduce;
        public Sprite preview;
    }
}
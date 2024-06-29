using System;
using System.Collections.Generic;
using Data;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class IllustratedHandbook : MonoBehaviour
    {
        [SerializeField] private Text culturalRelicName;
        [SerializeField] private Text introduce;
        [SerializeField] private Image preview;

        private List<CulturalRelicData> CulturalRelics =>DataManager.Instance.CulturalRelics;
        private int _currentIndex;
        

        public void Init()
        {
            gameObject.SetActive(true);
            _currentIndex = 0;
            
            UpdateCulturalRelic(CulturalRelics[_currentIndex]);
        }

        private void UpdateCulturalRelic(CulturalRelicData data)
        {
            culturalRelicName.text = data.culturalRelicName;
            introduce.text = data.introduce;
            preview.sprite = data.preview;
            preview.SetNativeSize();
            introduce.rectTransform.sizeDelta =
                new Vector2(introduce.rectTransform.sizeDelta.x, introduce.preferredHeight);
        }
        
        public void TurnLeft()
        {
            _currentIndex--;
            _currentIndex = _currentIndex < 0 ? CulturalRelics.Count - 1 : _currentIndex;
            UpdateCulturalRelic(CulturalRelics[_currentIndex]);
        }

        public void TurnRight()
        {
            _currentIndex++;
            _currentIndex = _currentIndex > CulturalRelics.Count - 1 ? 0 : _currentIndex;
            UpdateCulturalRelic(CulturalRelics[_currentIndex]);
        }
    }
}
using System;
using Data;
using PurpleFlowerCore;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class LevelIcon : MonoBehaviour
    {
        [SerializeField] private Sprite levelSprite;
        [SerializeField] private Sprite lockSprite;
        [SerializeField] private Image theSpriteRenderer;
        [SerializeField] private int index;
        [SerializeField] private Text levelName;
        private bool _isLock;
        public void Init(bool isLock)
        {
            theSpriteRenderer.color = isLock ? new Color(1, 1, 1, 0.5f) : new Color(1,1,1,1);

            _isLock = isLock;

            levelName.text = DataManager.Instance.GetLevelDataByIndex(index).levelName;
        }

        public void StartGame()
        {
            if (_isLock) return;
            DataManager.Instance.PassingData.CurrentLevel = DataManager.Instance.GetLevelDataByIndex(index);
            SceneSystem.LoadScene(DataManager.Instance.PassingData.CurrentLevel.sceneId);
        }
    }
}
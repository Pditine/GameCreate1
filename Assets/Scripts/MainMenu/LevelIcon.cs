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
        public void Init(bool isLock)
        {
            if (isLock) theSpriteRenderer.sprite = lockSprite;
            else theSpriteRenderer.sprite = levelSprite;

            levelName.text = DataManager.Instance.GetLevelDataByIndex(index).levelName;
        }

        public void StartGame()
        {
            DataManager.Instance.PassingData.CurrentLevel = DataManager.Instance.GetLevelDataByIndex(index);
            SceneSystem.LoadScene(DataManager.Instance.PassingData.CurrentLevel.sceneId);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using PurpleFlowerCore;
using PurpleFlowerCore.Utility;
using UnityEngine;

namespace GamePlay
{
    public class LevelManager : SingletonMono<LevelManager>
    {
        [SerializeField] private List<Fragment> fragments;
        [SerializeField] private PassPanel passPanel;
        [SerializeField] private Timer timer;

        private PassingData _passingData;

        private void Start()
        {
            _passingData = DataManager.Instance.PassingData;
        }

        public void CheckIntegrity()
        {
            if (fragments.Any(fragment => !fragment.IsFixed)) return;
            GameOver();
        }

        private void GameOver()
        {
            EventSystem.EventTrigger("GameOver");
            passPanel.Init(timer.CurrentTime);

            var nextLevel =
                DataManager.Instance.GetLevelDataByIndex(_passingData.CurrentLevel.index+1);
            if (nextLevel != null) nextLevel.canTry = true;
            _passingData.CurrentLevel.tryTime++;
            _passingData.CurrentLevel.UpdatePB(timer.CurrentTime);
        }


    }
}
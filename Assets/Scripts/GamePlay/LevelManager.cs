using System.Collections.Generic;
using System.Linq;
using PurpleFlowerCore;
using PurpleFlowerCore.Utility;
using UnityEngine;

namespace GamePlay
{
    public class LevelManager : SingletonMono<LevelManager>
    {
        [SerializeField] private List<Fragment> fragments;
        [SerializeField] private PassPanel passPanel;
        
        public void CheckIntegrity()
        {
            if (fragments.Any(fragment => !fragment.IsFixed)) return;
            GameOver();
        }

        private void GameOver()
        {
            EventSystem.EventTrigger("GameOver");
            passPanel.Init();
        }


    }
}
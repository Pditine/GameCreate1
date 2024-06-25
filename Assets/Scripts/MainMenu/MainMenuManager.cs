using UnityEngine;

namespace MainMenu
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private LevelSelection levelSelection;
        [SerializeField] private Record record;
        [SerializeField] private IllustratedHandbook illustratedHandbook;

        public void StartGame()
        {
            levelSelection.Init();
        }
        
        public void ShowRecord()
        {
            record.Init();
        }
        
        public void ShowIllustratedHandbook()
        {
            illustratedHandbook.Init();
        }
        
        public void Quit()
        {
            Application.Quit();
        }
    }
}
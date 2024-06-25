using PurpleFlowerCore;
using UnityEngine;
using UnityEngine.UI;

namespace GamePlay
{
    public class PassPanel : MonoBehaviour
    {
        [SerializeField] private Text timeText;
        public void Init(float time)
        {
            gameObject.SetActive(true);
            timeText.text = $"用时：{time:0:00}s";
        }
        
        public void BackToMain()
        {
            SceneSystem.LoadScene(0);
        }

        public void NextLevel()
        {
            
        }
    }
}
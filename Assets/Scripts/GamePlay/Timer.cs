using System;
using PurpleFlowerCore;
using UnityEngine;
using UnityEngine.UI;

namespace GamePlay
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private Text theText;
        private float _currentTime;
        public float CurrentTime => _currentTime;
        private bool _isGameOver;

        private void OnEnable()
        {
            EventSystem.AddEventListener("GameOver",IsGameOver);
        }

        private void OnDisable()
        {
            EventSystem.RemoveEventListener("GameOver",IsGameOver);
        }

        private void IsGameOver()
        {
            _isGameOver = true;
        }

        private void Update()
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            if (_isGameOver) return;
            _currentTime += Time.deltaTime;
            theText.text = $"用时：{_currentTime:0.00}s";
        }
    }
}
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace GamePlay
{
    public class Fragment : MonoBehaviour,IDragHandler,IEndDragHandler
    {
        public Transform target;
        [SerializeField] private float targetDistance = 30;

        private bool _isFixed;
        public bool IsFixed => _isFixed;
        
        public void OnDrag(PointerEventData eventData)
        {
            if (_isFixed) return;
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (Vector3.SqrMagnitude(target.position - transform.position) < targetDistance * targetDistance)
            {
                _isFixed = true;
                transform.position = target.position;
                LevelManager.Instance.CheckIntegrity();
            }
        }
    }
}
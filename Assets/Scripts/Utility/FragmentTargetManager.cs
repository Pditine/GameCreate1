using System;
using System.Collections.Generic;
using GamePlay;
using UnityEngine;

namespace Utility
{
    public class FragmentTargetManager : MonoBehaviour
    {
        [SerializeField] private List<Fragment> fragments;
        [SerializeField] private List<Transform> targets;

        private void Start()
        {
            for (int i = 0; i < fragments.Count; i++)
            {
                fragments[i].target = targets[i];
            }
        }
    }
}
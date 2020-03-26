using System;
using UnityEngine;

namespace Game
{
    public class DeathBase : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private GameObject _root;

#pragma warning restore 0649
        #endregion

        public GameObject Root => _root;

        public event Action OnDeath;

        public void Death()
        {
            OnDeath?.Invoke();
            Destroy(Root);
        }
    }
}

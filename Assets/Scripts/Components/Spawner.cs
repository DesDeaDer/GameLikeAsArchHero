using System;
using UnityEngine;

namespace Game
{
    public class Spawner : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private Transform _root;
        [SerializeField] private Transform _rootPreference;
        [SerializeField] private GameObject _prototype;

#pragma warning restore 0649
        #endregion

        public GameObject Prototype => _prototype;
        public Transform Root => _root;
        public Transform RootPreference => _rootPreference;

        public event Action OnSpawn;

        public void Spawn()
        {
            if (Prototype)
            {
                var position = RootPreference?.position ?? default;
                var rotation = RootPreference?.rotation ?? default;
                var instance = Instantiate(Prototype, position, rotation, Root);
                instance.SetActive(true);
                OnSpawn?.Invoke();
            }
        }
    }
}

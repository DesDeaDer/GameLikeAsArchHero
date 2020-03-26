using System;
using UnityEngine;

namespace Game
{
    public class Cooldown : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private FloatAttribute _spawnRate;
        [SerializeField] private FloatAttribute _startPercent;

#pragma warning restore 0649
        #endregion

        public float SpawnRate => _spawnRate.Value;
        public float StartPercent => _startPercent.Value;

        public float RemainingTime { get; private set; }

        public event Action OnReady;

        private void OnEnable() => RemainingTime = SpawnRate * Mathf.Max(0, StartPercent);

        private void Update()
        {
            RemainingTime -= Time.deltaTime;

            if (RemainingTime <= 0)
            {
                RemainingTime += SpawnRate;

                OnReady?.Invoke();
            }
        }
    }
}

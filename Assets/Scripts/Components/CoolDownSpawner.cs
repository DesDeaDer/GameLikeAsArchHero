using UnityEngine;

namespace Game
{
    public class CoolDownSpawner : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private Cooldown _cooldown;
        [SerializeField] private Spawner _spawner;

#pragma warning restore 0649
        #endregion

        public Cooldown Cooldown => _cooldown;
        public Spawner Spawner => _spawner;

        private void OnEnable() => Cooldown.OnReady += OnReadyCooldownHandler;
        private void OnDisable() => Cooldown.OnReady -= OnReadyCooldownHandler;

        private void OnReadyCooldownHandler() => Spawner.Spawn();
    }
}

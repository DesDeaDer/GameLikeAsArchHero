using UnityEngine;

namespace Game
{
    public class DeathOnDamaged : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private DamageDealer _damageDealer;
        [SerializeField] private DeathBase _deathBase;

#pragma warning restore 0649
        #endregion

        public DamageDealer DamageDealer => _damageDealer;
        public DeathBase DeathBase => _deathBase;

        private void OnEnable() => DamageDealer.OnDamaged += OnDamagedHandler;
        private void OnDisable() => DamageDealer.OnDamaged -= OnDamagedHandler;

        private void OnDamagedHandler() => DeathBase.Death();
    }
}

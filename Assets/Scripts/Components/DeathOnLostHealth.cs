using UnityEngine;

namespace Game
{
    public class DeathOnLostHealth : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private FloatAttribute _health;
        [SerializeField] private DeathBase _deathBase;

#pragma warning restore 0649
        #endregion

        public FloatAttribute Health => _health;
        public DeathBase DeathBase => _deathBase;

        private void OnEnable() => Health.OnChange += OnChangeHealthHandler;
        private void OnDisable() => Health.OnChange -= OnChangeHealthHandler;

        private void OnChangeHealthHandler()
        {
            if (Health.Value <= 0)
            {
                DeathBase.Death();
            }
        }
    }
}

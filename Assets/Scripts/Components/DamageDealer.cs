using System;
using UnityEngine;

namespace Game
{
    public class DamageDealer : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private FloatAttribute _damage;
        [SerializeField] private DamageTypeAttribute _damageType;

#pragma warning restore 0649
        #endregion

        public FloatAttribute Damage => _damage;
        public DamageTypeAttribute DamageType => _damageType;

        public event Action OnDamaged;

        public void Damaged() => OnDamaged?.Invoke();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var reciver = collision.GetComponent<DamageReciver>();
            if (reciver)
            {
                reciver.Damage(Damage, DamageType);

                if (reciver.DamageType.IsAny(DamageType))
                {
                    Damaged();
                }
            }
        }
    }
}

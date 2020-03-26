using UnityEngine;

namespace Game
{
    public class DamageReciver : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private FloatAttribute _health;
        [SerializeField] private DamageTypeAttribute _damageType;

#pragma warning restore 0649
        #endregion

        public AttributeBase<float> Health => _health;
        public DamageTypeAttribute DamageType => _damageType;

        public void Damage(AttributeBase<float> damage, AttributeBase<DamageID> damageType)
        {
            if (Health && DamageType.IsAny(damageType))
            {
                Health.Value -= damage?.Value ?? default;
            }
        }
    }
}

using System;
using UnityEngine;

namespace Game
{
    public abstract class AttributeBase : MonoBehaviour
    {
        public event Action OnChange;
        public void Change() => OnChange();
    }

    public class AttributeBase<T> : AttributeBase
    {

        #region Data
#pragma warning disable 0649

        [SerializeField] private T _value;

#pragma warning restore 0649
        #endregion

        public T Value
        {
            get => _value;
            set
            {
                if (!_value.Equals(value))
                {
                    _value = value;
                    Change();
                }
            }
        }
    }
}

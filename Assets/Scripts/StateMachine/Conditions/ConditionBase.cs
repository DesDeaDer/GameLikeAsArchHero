using System;
using UnityEngine;

namespace Game
{
    public abstract class ConditionBase : MonoBehaviour
    {
        public bool IsReady { get; protected set; }

        public event Action<bool> OnChange;

        public void Ready(bool isReady) => OnChange?.Invoke(isReady);
    }
}

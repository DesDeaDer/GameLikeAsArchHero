using UnityEngine;

namespace Game
{
    public class State : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private InterruptBase _interrupt;
        [SerializeField] private BehaviourBase _behaviour;

#pragma warning restore 0649
        #endregion

        public InterruptBase Interrupt => _interrupt;
        public BehaviourBase Behaviour => _behaviour;
    }
}

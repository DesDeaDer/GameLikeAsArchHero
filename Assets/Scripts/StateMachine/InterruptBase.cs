using UnityEngine;

namespace Game
{
    public class InterruptBase : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private FloatAttribute _priority;
        [SerializeField] private ConditionBase _condition;
        [SerializeField] private State _state;

#pragma warning restore 0649
        #endregion

        public AttributeBase<float> Priority => _priority;
        public ConditionBase Condition => _condition;
        public State State => _state;

        //TODO
    }

}

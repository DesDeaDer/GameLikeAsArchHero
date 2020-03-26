using UnityEngine;

namespace Game
{
    public class InputMovementAggregator : InputMovementBase
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private InputMovementBase[] _inputs;

#pragma warning restore 0649
        #endregion

        public InputMovementBase[] Inputs => _inputs;

        public override Vector2 Value => AggregateInputs();

        private Vector2 AggregateInputs()
        {
            var input = Vector2.zero;
            var length = Inputs.Length;
            for (int i = 0; i < length; i++)
            {
                input += Inputs[i].Value.normalized;
            }
            return input;
        }
    }
}

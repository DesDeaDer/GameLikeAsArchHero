using UnityEngine;

namespace Game
{
    public abstract class ScreenMovement : InputMovementBase
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private Transform _targetObject;
        [SerializeField] private Camera _targetCamera;
        [SerializeField] private float _epsilonDistance;

#pragma warning restore 0649
        #endregion

        public Transform TargetObject => _targetObject;
        public Camera TargetCamera => _targetCamera;
        public float EpsilonDistance => _epsilonDistance;

        public override Vector2 Value => GetInput();

        private Vector2 GetInput()
        {
            var result = Vector2.zero;
            if (TryGetInput(out var position))
            {
                var worldPosition = (Vector2)TargetCamera.ScreenToWorldPoint(position);
                var targetPosition = (Vector2)TargetObject.position;
                var delta = worldPosition - targetPosition;

                if (delta.magnitude > _epsilonDistance)
                {
                    result = delta;
                }
            }

            return result;
        }

        abstract protected bool TryGetInput(out Vector2 input);
    }
}

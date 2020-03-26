using UnityEngine;

namespace Game
{
    public class TransformMovement : InputMovementBase
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private Vector2 _direction;

#pragma warning restore 0649
        #endregion

        public Vector2 Direction => _direction;

        public override Vector2 Value => (transform.right * Direction.x
            + transform.up * Direction.y).normalized;
    }
}

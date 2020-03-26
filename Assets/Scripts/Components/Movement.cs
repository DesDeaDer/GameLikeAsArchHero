using UnityEngine;

namespace Game
{
    public class Movement : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private FloatAttribute _movementSpeed;
        [SerializeField] private InputMovementBase _input;
        [SerializeField] private Rigidbody2D _rigidbody2D;

#pragma warning restore 0649
        #endregion

        public float MovementSpeed => _movementSpeed.Value;
        public InputMovementBase Input => _input;
        public Rigidbody2D Rigidbody2D => _rigidbody2D;

        private void Update()
        {
            Rigidbody2D.velocity = GetVelocity(Input.Value, MovementSpeed);
        }

        private Vector2 GetVelocity(Vector2 input, float movementSpeed) => new Vector2(input.x, input.y).normalized * movementSpeed;
    }
}

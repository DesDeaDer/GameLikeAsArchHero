using UnityEngine;

namespace Game
{
    public class WasdMovement : InputMovementBase
    {
        public override Vector2 Value => GetInput();

        private Vector2 GetInput()
        {
            var result = Vector2.zero;
            if (UnityEngine.Input.GetKey(KeyCode.W))
            {
                result.y = 1;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.S))
            {
                result.y = -1;
            }
            if (UnityEngine.Input.GetKey(KeyCode.A))
            {
                result.x = -1;
            }
            if (UnityEngine.Input.GetKey(KeyCode.D))
            {
                result.x = 1;
            }

            return result;
        }
    }
}

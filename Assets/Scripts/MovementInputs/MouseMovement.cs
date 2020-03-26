using UnityEngine;

namespace Game
{
    public class MouseMovement : ScreenMovement
    {
        protected override bool TryGetInput(out Vector2 input)
        {
            if (Input.GetMouseButton(0))
            {
                input = Input.mousePosition;
                return true;
            }

            input = default;
            return false;
        }
    }
}

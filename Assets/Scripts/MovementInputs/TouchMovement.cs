using UnityEngine;

namespace Game
{
    public class TouchMovement : ScreenMovement
    {
        protected override bool TryGetInput(out Vector2 input)
        {
            if (Input.touchCount > 0)
            {
                input = Input.touches[0].position;
                return true;
            }

            input = default;
            return false;
        }
    }
}

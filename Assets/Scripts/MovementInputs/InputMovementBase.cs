using UnityEngine;

namespace Game
{
    public abstract class InputMovementBase : MonoBehaviour
    {
        abstract public Vector2 Value { get; }
    }
}

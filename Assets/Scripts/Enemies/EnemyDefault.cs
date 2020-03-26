using UnityEngine;

namespace StateMachine
{
    public class State : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private Interrupt _interrupt;
        [SerializeField] private Action _action;

#pragma warning restore 0649
        #endregion

        public Interrupt Interrupt => _interrupt;
        public Action Action => _action;
    }

    public class Action : MonoBehaviour
    {

    }

    public class Interrupt : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private Interrupt _interrupt;
        [SerializeField] private State _state;

#pragma warning restore 0649
        #endregion

    }

    public class StateMachine : MonoBehaviour
    {

    }

}

namespace Game
{

    public class Weapon : MonoBehaviour
    {
        public void Shoot(Transform Target) { }
    }

    public class EnemyDefault : MonoBehaviour
    {
        [SerializeField] private Weapon _weapon;
    }
}

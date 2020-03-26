using System;
using UnityEngine;

namespace Game
{
    public class StateMachine : MonoBehaviour
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private State _stateFirst;

#pragma warning restore 0649
        #endregion

        public State StateFirst => _stateFirst;

        private void OnEnable()
        {
            Run(StateFirst);
        }

        private void Run(State state) => throw new NotImplementedException();

        //TODO
    }
}

using UnityEngine;

namespace Game
{
    public abstract class AttributeCondition<A> : ConditionBase where A : AttributeBase
    {
        #region Data
#pragma warning disable 0649

        [SerializeField] private A _attributeFirst;
        [SerializeField] private A _attributeSecond;

#pragma warning restore 0649
        #endregion

        public A AttributeFirst => _attributeFirst;
        public A AttributeSecond => _attributeSecond;

        private void OnEnable()
        {
            AttributeFirst.OnChange += OnChangeAttributeFirstHandler;
            AttributeSecond.OnChange += OnChangeAttributeSecondHandler;

            CheckCondition();
        }

        private void OnDisable()
        {
            AttributeFirst.OnChange -= OnChangeAttributeFirstHandler;
            AttributeSecond.OnChange -= OnChangeAttributeSecondHandler;
        }

        private void OnChangeAttributeSecondHandler() => CheckCondition();
        private void OnChangeAttributeFirstHandler() => CheckCondition();

        private void CheckCondition()
        {
            var isReady = IsCondition(AttributeFirst, AttributeSecond);

            if (IsReady != isReady)
            {
                IsReady = isReady;
                Ready(isReady);
            }
        }

        public abstract bool IsCondition(A first, A second);
    }
}

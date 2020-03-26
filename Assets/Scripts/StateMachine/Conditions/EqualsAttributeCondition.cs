using System;
namespace Game
{
    public class EqualsAttributeCondition<A, T> : AttributeCondition<A>
        where A : AttributeBase<T>
        where T : IEquatable<T>
    {
        public override bool IsCondition(A first, A second) => first.Value.Equals(second.Value);
    }
}

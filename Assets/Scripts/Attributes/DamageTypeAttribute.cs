namespace Game
{
    public class DamageTypeAttribute : AttributeBase<DamageID>
    {
        public bool IsAny(DamageID damageID) => ((DamageID)((int)Value & (int)damageID) > DamageID.None);
        public bool IsAll(DamageID damageID) => ((DamageID)((int)Value & (int)damageID) == DamageID.None);

        public bool IsAny(AttributeBase<DamageID> damageType) => IsAny(damageType.Value);
        public bool IsAll(AttributeBase<DamageID> damageType) => IsAll(damageType.Value);
    }
}

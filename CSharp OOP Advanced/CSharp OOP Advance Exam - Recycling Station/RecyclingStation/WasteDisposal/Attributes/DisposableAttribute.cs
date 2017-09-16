namespace RecyclingStation.WasteDisposal.Attributes
{
    using System;

    /// <summary>
    /// An attribute class, that represents the base of all Disposable Attribute classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DisposableAttribute : Attribute
    {
        public Type CorrespondingStrategyType { get; private set; }

        public DisposableAttribute(Type correspondingStrategyType)
        {
            this.CorrespondingStrategyType = correspondingStrategyType;
        }
    }
}

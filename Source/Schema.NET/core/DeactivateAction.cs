namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    public partial interface IDeactivateAction : IControlAction
    {
    }

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    [DataContract]
    public partial class DeactivateAction : ControlAction, IDeactivateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeactivateAction";
    }
}

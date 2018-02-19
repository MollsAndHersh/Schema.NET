using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    [DataContract]
    public partial class ChildrensEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChildrensEvent";
    }
}

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    [DataContract]
    public partial class DefenceEstablishment : GovernmentBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DefenceEstablishment";
    }
}

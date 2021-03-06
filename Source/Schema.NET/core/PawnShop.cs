using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    [DataContract]
    public partial class PawnShop : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PawnShop";
    }
}

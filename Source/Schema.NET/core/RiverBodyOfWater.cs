namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    [DataContract]
    public partial class RiverBodyOfWater : BodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RiverBodyOfWater";
    }
}

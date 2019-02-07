namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An educational organization.
    /// </summary>
    [DataContract]
    public partial class EducationalOrganization : Organization
    {

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalOrganization";

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 206)]
        public override OneOrManyAlumni Alumni { get; set; }
    }
}

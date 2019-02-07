namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// </summary>
    [DataContract]
    public partial class DiagnosticProcedure : MedicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticProcedure";
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    [DataContract]
    public partial class BankOrCreditUnion : FinancialService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BankOrCreditUnion";
    }
}

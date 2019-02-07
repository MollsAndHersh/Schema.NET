namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A sequential publication of comic stories under a
    ///     unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///     Wanderer".
    /// </summary>
    [DataContract]
    public partial class ComicSeries : Periodical
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicSeries";
    }
}

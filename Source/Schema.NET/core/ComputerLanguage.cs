using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="http://schema.org/Language"&gt;Language&lt;/a&gt; type.
    /// </summary>
    [DataContract]
    public partial class ComputerLanguage : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComputerLanguage";
    }
}

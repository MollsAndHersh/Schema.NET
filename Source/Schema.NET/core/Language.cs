using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in &lt;a href="https://en.wikipedia.org/wiki/IETF_language_tag"&gt;BCP 47&lt;/a&gt; can be used via the &lt;a class="localLink" href="http://schema.org/alternateName"&gt;alternateName&lt;/a&gt; property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using &lt;a class="localLink" href="http://schema.org/ComputerLanguage"&gt;ComputerLanguage&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Language : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Language";
    }
}

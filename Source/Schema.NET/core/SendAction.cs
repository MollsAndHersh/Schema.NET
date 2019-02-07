namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SendAction : TransferAction
    {
        public interface IDeliveryMethod : IValue {}
        public interface IDeliveryMethod<T> : IDeliveryMethod { new T Value { get; } }
        public class OneOrManyDeliveryMethod : OneOrMany<IDeliveryMethod>
        {
            public OneOrManyDeliveryMethod(IDeliveryMethod item) : base(item) { }
            public OneOrManyDeliveryMethod(IEnumerable<IDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyDeliveryMethod (DeliveryMethod value) { return new OneOrManyDeliveryMethod (new DeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyDeliveryMethod (values.Select(v => (IDeliveryMethod) new DeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyDeliveryMethod (values.Select(v => (IDeliveryMethod) new DeliveryMethodDeliveryMethod (v))); }
        }
        public struct DeliveryMethodDeliveryMethod : IDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public DeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator DeliveryMethodDeliveryMethod (DeliveryMethod value) { return new DeliveryMethodDeliveryMethod (value); }
        }

        public interface IRecipient : IValue {}
        public interface IRecipient<T> : IRecipient { new T Value { get; } }
        public class OneOrManyRecipient : OneOrMany<IRecipient>
        {
            public OneOrManyRecipient(IRecipient item) : base(item) { }
            public OneOrManyRecipient(IEnumerable<IRecipient> items) : base(items) { }
            public static implicit operator OneOrManyRecipient (Audience value) { return new OneOrManyRecipient (new RecipientAudience (value)); }
            public static implicit operator OneOrManyRecipient (Audience[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientAudience (v))); }
            public static implicit operator OneOrManyRecipient (List<Audience> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientAudience (v))); }
            public static implicit operator OneOrManyRecipient (ContactPoint value) { return new OneOrManyRecipient (new RecipientContactPoint (value)); }
            public static implicit operator OneOrManyRecipient (ContactPoint[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientContactPoint (v))); }
            public static implicit operator OneOrManyRecipient (List<ContactPoint> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientContactPoint (v))); }
            public static implicit operator OneOrManyRecipient (Organization value) { return new OneOrManyRecipient (new RecipientOrganization (value)); }
            public static implicit operator OneOrManyRecipient (Organization[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientOrganization (v))); }
            public static implicit operator OneOrManyRecipient (List<Organization> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientOrganization (v))); }
            public static implicit operator OneOrManyRecipient (Person value) { return new OneOrManyRecipient (new RecipientPerson (value)); }
            public static implicit operator OneOrManyRecipient (Person[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientPerson (v))); }
            public static implicit operator OneOrManyRecipient (List<Person> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientPerson (v))); }
        }
        public struct RecipientAudience : IRecipient<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public RecipientAudience (Audience value) { Value = value; }
            public static implicit operator RecipientAudience (Audience value) { return new RecipientAudience (value); }
        }
        public struct RecipientContactPoint : IRecipient<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public RecipientContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator RecipientContactPoint (ContactPoint value) { return new RecipientContactPoint (value); }
        }
        public struct RecipientOrganization : IRecipient<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public RecipientOrganization (Organization value) { Value = value; }
            public static implicit operator RecipientOrganization (Organization value) { return new RecipientOrganization (value); }
        }
        public struct RecipientPerson : IRecipient<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public RecipientPerson (Person value) { Value = value; }
            public static implicit operator RecipientPerson (Person value) { return new RecipientPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SendAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        public OneOrManyDeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 307)]
        public OneOrManyRecipient Recipient { get; set; }
    }
}

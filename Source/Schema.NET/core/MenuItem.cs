using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    [DataContract]
    public partial class MenuItem : Intangible
    {
        public interface IMenuAddOn : IWrapper { }
        public interface IMenuAddOn<T> : IMenuAddOn { new T Data { get; set; } }
        public class MenuAddOnMenuItem : IMenuAddOn<MenuItem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MenuItem) value; } }
            public virtual MenuItem Data { get; set; }
            public MenuAddOnMenuItem () { }
            public MenuAddOnMenuItem (MenuItem data) { Data = data; }
            public static implicit operator MenuAddOnMenuItem (MenuItem data) { return new MenuAddOnMenuItem (data); }
        }

        public class MenuAddOnMenuSection : IMenuAddOn<MenuSection>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MenuSection) value; } }
            public virtual MenuSection Data { get; set; }
            public MenuAddOnMenuSection () { }
            public MenuAddOnMenuSection (MenuSection data) { Data = data; }
            public static implicit operator MenuAddOnMenuSection (MenuSection data) { return new MenuAddOnMenuSection (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MenuItem";

        /// <summary>
        /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
        /// </summary>
        [DataMember(Name = "menuAddOn", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMenuAddOn>? MenuAddOn { get; set; } //MenuItem, MenuSection

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<NutritionInformation>? Nutrition { get; set; } 

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; } 

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RestrictedDiet>? SuitableForDiet { get; set; } 
    }
}

using System;

namespace PageObject.Elements.Attributes
{
    /// <summary>
    /// Attribute locator for Element
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class FindElementByAttribute: Attribute
    {
        /// <summary>
        /// Locator type
        /// </summary>
        public FindType FindType { get; set; }
        /// <summary>
        /// String locator
        /// </summary>
        public string Locator { get; set; }
    }
}

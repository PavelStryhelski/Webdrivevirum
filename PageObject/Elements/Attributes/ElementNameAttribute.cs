using System;

namespace PageObject.Elements.Attributes
{
    /// <summary>
    /// Element name attribute
    /// </summary>
    public class ElementNameAttribute: Attribute
    {
        /// <summary>
        /// Element name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Element name ctor
        /// </summary>
        /// <param name="name">Element name</param>
        public ElementNameAttribute(string name)
        {
            Name = name;
        }
    }
}

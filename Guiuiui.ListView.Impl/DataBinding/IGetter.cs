//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Represents an abstraction of a property getter.
    /// </summary>
    /// <typeparam name="TPropertyValue">
    /// Type of the property
    /// </typeparam>
    public interface IGetter<TPropertyValue>
    {
        /// <summary>
        /// Gets the property value.
        /// </summary>
        TPropertyValue Get();
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.DataBinding
{
    /// <summary>
    /// Represents an abstraction of a property getter.
    /// </summary>
    public interface IGetter<TPropertyValue>
    {
        /// <summary>
        /// Gets the property value.
        /// </summary>
        TPropertyValue Get();
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.DataBinding
{
    /// <summary>
    /// Represents an abstraction of a property setter.
    /// </summary>
    public interface ISetter<TPropertyValue>
    {
        /// <summary>
        /// Sets the property value.
        /// </summary>
        void Set(TPropertyValue value);
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    /// <summary>
    /// Has to be notified when a value has changed.
    /// </summary>
    public interface INotifiable
    {
        /// <summary>
        /// Notifies this, that one of its values must have changed.
        /// </summary>
        void NotifyValueHasChanged();
    }
}

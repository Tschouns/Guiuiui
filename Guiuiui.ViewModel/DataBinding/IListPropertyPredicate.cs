//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using Guiuiui.ViewModel.List;

    /// <summary>
    /// Provides an interface to bind a list control to the list property.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface IListPropertyPredicate<TListItem>
    {
        /// <summary>
        /// Binds a list control to the list property.
        /// </summary>
        void ToListControl(IListControl<TListItem> listControl);
    }
}

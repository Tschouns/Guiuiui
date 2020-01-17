//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.DataBinding
{
    using Guiuiui.ViewModel;

    /// <summary>
    /// Allows to add view models, which are then used to represent selected items.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface IHasItemViewModels<TListItem>
        where TListItem : class
    {
        /// <summary>
        /// Adds a view model which is used to represent a selected item.
        /// </summary>
        void AddViewModelForSelectedItem(IViewModel<TListItem> viewModel);
    }
}

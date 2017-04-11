//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Creates pre-defined cell bindings for specific list item instances.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface ICellBindingFactory<TListItem>
    {
        /// <summary>
        /// Creates a pre-defined cell binding for the specified list item and cell.
        /// </summary>
        ICellBinding CreateCellBindingForItem(TListItem listItem, ICell cell);
    }
}

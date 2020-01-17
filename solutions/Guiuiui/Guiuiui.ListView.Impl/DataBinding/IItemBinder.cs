//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Contains a list item, and all the cell bindings for that specific list item.
    /// </summary>
    public interface IItemBinder
    {
        /// <summary>
        /// Updates all the cells (columns) bound to the item.
        /// </summary>
        void UpdateCells();
    }
}

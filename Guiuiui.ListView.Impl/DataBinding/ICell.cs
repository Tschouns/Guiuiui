//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Represents a cell (column) within a list view.
    /// </summary>
    public interface ICell
    {
        /// <summary>
        /// Sets the cell text.
        /// </summary>
        void SetText(string text);
    }
}

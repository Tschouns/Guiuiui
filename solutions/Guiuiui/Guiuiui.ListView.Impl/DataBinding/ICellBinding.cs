//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Represents a single binding between a property and a list view cell.
    /// </summary>
    public interface ICellBinding
    {
        /// <summary>
        /// Updates value displayed int the cell.
        /// </summary>
        void UpdateCell();
    }
}

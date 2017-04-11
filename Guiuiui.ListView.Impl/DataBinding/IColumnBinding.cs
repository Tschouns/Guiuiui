//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Represents a single binding between a property and a column.
    /// </summary>
    public interface IColumnBinding
    {
        /// <summary>
        /// Gets a value indicating whether this column binding is active, or already "unbound".
        /// </summary>
        bool IsBound { get; }

        /// <summary>
        /// "Unbinds" the property and column, i.e. makes this column binding ineffective. Unregisters
        /// any event handlers.
        /// </summary>
        void Unbind();

        /// <summary>
        /// Updates value displayed int the column.
        /// </summary>
        void Update();
    }
}

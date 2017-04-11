//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    /// <summary>
    /// Contains a list item, and all the column bindings for that specific list item.
    /// </summary>
    public interface IItemBinder
    {
        /// <summary>
        /// Gets a value indicating whether the column bindings are active, or already "unbound".
        /// </summary>
        bool IsBound { get; }

        /// <summary>
        /// "Unbinds" all the column bindings, i.e. makes this "item binder" ineffective. Unregisters
        /// any event handlers.
        /// </summary>
        void UnbindAll();

        /// <summary>
        /// Updates all the columns bound to the item.
        /// </summary>
        void UpdateColumns();
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.ItemProvider
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides items, which can then be added to or removed from a collection.
    /// </summary>
    /// <typeparam name="TItem">
    /// Type of the items provided this interface
    /// </typeparam>
    /// <remarks>
    /// This interface is meant to be implemented for extendability.
    /// </remarks>
    public interface IItemProvider<TItem>
        where TItem : class
    {
        /// <summary>
        /// Raised whenever the state of the object has changed, and hence the <see cref="IsRetrievePossible"/>
        /// property may have changed.
        /// </summary>
        event EventHandler StateChanged;

        /// <summary>
        /// Gets a value indicating whether it is currently possible to retrieve any items.
        /// </summary>
        bool IsRetrievePossible { get; }

        /// <summary>
        /// Retrieves items.
        /// </summary>
        IEnumerable<TItem> RetrieveItems();
    }
}

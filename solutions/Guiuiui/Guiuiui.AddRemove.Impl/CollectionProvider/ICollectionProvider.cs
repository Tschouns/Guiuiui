//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl.CollectionProvider
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides a collection, items can be added to or removed from.
    /// </summary>
    /// <typeparam name="TCollectionItem">
    /// Type of the items in the collection
    /// </typeparam>
    public interface ICollectionProvider<TCollectionItem>
        where TCollectionItem : class
    {
        /// <summary>
        /// Raised whenever the collection has, or may have, changed.
        /// </summary>
        event EventHandler CollectionChanged;

        /// <summary>
        /// Gets the collection. Can be <c>null</c>.
        /// </summary>
        ICollection<TCollectionItem> Collection { get; }
    }
}

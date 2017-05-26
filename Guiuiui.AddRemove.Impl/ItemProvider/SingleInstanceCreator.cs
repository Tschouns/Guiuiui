//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl.ItemProvider
{
    using System;
    using System.Collections.Generic;
    using Guiuiui.AddRemove.ItemProvider;

    /// <summary>
    /// See <see cref="IItemProvider{TItem}"/>. Creates a single instance of <typeparamref name="TItem"/> whenever
    /// <see cref="IItemProvider{TItem}.RetrieveItems"/> is called.
    /// </summary>
    /// <typeparam name="TItem">
    /// Type of the created item
    /// </typeparam>
    public class SingleInstanceCreator<TItem> : IItemProvider<TItem>
        where TItem : class, new()
    {
        /// <summary>
        /// See <see cref="IItemProvider{TItem}.StateChanged"/>.
        /// </summary>
        public event EventHandler StateChanged;

        /// <summary>
        /// See <see cref="IItemProvider{TItem}.IsRetrievePossible"/>.
        /// </summary>
        public bool IsRetrievePossible => true;

        /// <summary>
        /// See <see cref="IItemProvider{TItem}.RetrieveItems"/>.
        /// </summary>
        public IEnumerable<TItem> RetrieveItems()
        {
            return new[] { new TItem() };
        }
    }
}

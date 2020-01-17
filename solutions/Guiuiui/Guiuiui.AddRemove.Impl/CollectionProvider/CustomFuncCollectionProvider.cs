//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl.CollectionProvider
{
    using System;
    using System.Collections.Generic;
    using Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="ICollectionProvider{TCollectionItem}"/>. Retrieves the collection via a
    /// function specified at initialization time.
    /// </summary>
    /// <typeparam name="TCollectionItem">
    /// Type of the items in the collection
    /// </typeparam>
    public class CustomFuncCollectionProvider<TCollectionItem> : ICollectionProvider<TCollectionItem>
        where TCollectionItem : class
    {
        private readonly Func<ICollection<TCollectionItem>> _getItemCollectionFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFuncCollectionProvider{TCollectionItem}"/> class.
        /// </summary>
        public CustomFuncCollectionProvider(Func<ICollection<TCollectionItem>> getItemCollectionFunc)
        {
            ArgumentChecks.AssertNotNull(getItemCollectionFunc, nameof(getItemCollectionFunc));

            this._getItemCollectionFunc = getItemCollectionFunc;
        }

        /// <summary>
        /// See <see cref="ICollectionProvider{TCollectionItem}.CollectionChanged"/>.
        /// </summary>
        public event EventHandler CollectionChanged;

        /// <summary>
        /// See <see cref="ICollectionProvider{TCollectionItem}.Collection"/>.
        /// </summary>
        public ICollection<TCollectionItem> Collection => this._getItemCollectionFunc();
    }
}

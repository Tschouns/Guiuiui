//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using System;
    using System.Collections.Generic;
    using Base.RuntimeChecks;
    using ViewModel.List;

    /// <summary>
    /// See <see cref="IAddRemoveFactory"/>
    /// </summary>
    public class AddRemoveFactory : IAddRemoveFactory
    {
        /// <summary>
        /// See <see cref="IAddRemoveFactory.CreateAddRemoveController{TItem}(Func{ICollection{TItem}}, IItemProvider{TItem}, ISelection{TItem})"/>.
        /// </summary>
        public IAddRemove CreateAddRemoveController<TItem>(
            Func<ICollection<TItem>> getItemCollectionFunc,
            IItemProvider<TItem> addItemProvider,
            ISelection<TItem> removeSelection)
            where TItem : class
        {
            ArgumentChecks.AssertNotNull(getItemCollectionFunc, nameof(getItemCollectionFunc));
            ArgumentChecks.AssertNotNull(addItemProvider, nameof(addItemProvider));
            ArgumentChecks.AssertNotNull(removeSelection, nameof(removeSelection));

            return new AddRemoveController<TItem>(
                getItemCollectionFunc,
                addItemProvider,
                new SelectionWrapper<TItem>(removeSelection));
        }
    }
}

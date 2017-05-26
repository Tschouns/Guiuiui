//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using System;
    using System.Collections.Generic;
    using AddRemove.ItemProvider;
    using Base.RuntimeChecks;
    using ViewModel;
    using ItemProvider;
    using ViewModel.List;
    using CollectionProvider;

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
                new CustomFuncCollectionProvider<TItem>(getItemCollectionFunc),
                addItemProvider,
                new SelectionWrapper<TItem>(removeSelection));
        }

        /// <summary>
        /// See <see cref="IAddRemoveFactory.CreateAddRemoveController{TItem}(Func{ICollection{TItem}}, ISelection{TItem})"/>.
        /// </summary>
        public IAddRemove CreateAddRemoveController<TItem>(
            Func<ICollection<TItem>> getItemCollectionFunc,
            ISelection<TItem> removeSelection)
            where TItem : class, new()
        {
            ArgumentChecks.AssertNotNull(getItemCollectionFunc, nameof(getItemCollectionFunc));
            ArgumentChecks.AssertNotNull(removeSelection, nameof(removeSelection));

            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IAddRemoveFactory.CreateAddRemoveController{TParentItem, TItem}(IViewModel{TParentItem}, Func{TParentItem, ICollection{TItem}}, IItemProvider{TItem}, ISelection{TItem})"/>.
        /// </summary>
        public IAddRemove CreateAddRemoveController<TParentItem, TItem>(
            IViewModel<TParentItem> parentViewModel,
            Func<TParentItem, ICollection<TItem>> getItemCollectionPropertyFunc,
            IItemProvider<TItem> addItemProvider,
            ISelection<TItem> removeSelection)
            where TParentItem : class
            where TItem : class
        {
            ArgumentChecks.AssertNotNull(parentViewModel, nameof(parentViewModel));
            ArgumentChecks.AssertNotNull(getItemCollectionPropertyFunc, nameof(getItemCollectionPropertyFunc));
            ArgumentChecks.AssertNotNull(addItemProvider, nameof(addItemProvider));
            ArgumentChecks.AssertNotNull(removeSelection, nameof(removeSelection));

            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IAddRemoveFactory.CreateAddRemoveController{TParentItem, TItem}(IViewModel{TParentItem}, Func{TParentItem, ICollection{TItem}}, ISelection{TItem})"/>.
        /// </summary>
        public IAddRemove CreateAddRemoveController<TParentItem, TItem>(
            IViewModel<TParentItem> parentViewModel,
            Func<TParentItem, ICollection<TItem>> getItemCollectionPropertyFunc,
            ISelection<TItem> removeSelection)
            where TParentItem : class
            where TItem : class, new()
        {
            ArgumentChecks.AssertNotNull(parentViewModel, nameof(parentViewModel));
            ArgumentChecks.AssertNotNull(getItemCollectionPropertyFunc, nameof(getItemCollectionPropertyFunc));
            ArgumentChecks.AssertNotNull(removeSelection, nameof(removeSelection));

            throw new NotImplementedException();
        }
    }
}

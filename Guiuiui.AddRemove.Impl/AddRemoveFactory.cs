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
    using AddRemove.ButtonController;
    using System.Windows.Forms;
    using ButtonController;

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

            return new AddRemoveController<TItem>(
                new CustomFuncCollectionProvider<TItem>(getItemCollectionFunc),
                new SingleInstanceCreator<TItem>(),
                new SelectionWrapper<TItem>(removeSelection));
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

            var collectionProvider = new ParentViewModelCollectionProvider<TParentItem, TItem>(
                parentViewModel,
                getItemCollectionPropertyFunc);

            return new AddRemoveController<TItem>(
                collectionProvider,
                addItemProvider,
                new SelectionWrapper<TItem>(removeSelection));
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

            var collectionProvider = new ParentViewModelCollectionProvider<TParentItem, TItem>(
                parentViewModel,
                getItemCollectionPropertyFunc);

            return new AddRemoveController<TItem>(
                collectionProvider,
                new SingleInstanceCreator<TItem>(),
                new SelectionWrapper<TItem>(removeSelection));
        }

        /// <summary>
        /// See <see cref="IAddRemoveFactory.AttachToButtons(IAddRemove, Button, Button)"/>.
        /// </summary>
        public IButtonController AttachToButtons(
            IAddRemove addRemoveController,
            Button addButton,
            Button removeButton)
        {
            ArgumentChecks.AssertNotNull(addRemoveController, nameof(addRemoveController));
            ArgumentChecks.AssertNotNull(addButton, nameof(addButton));
            ArgumentChecks.AssertNotNull(removeButton, nameof(removeButton));

            return new LockButtonController(
                addButton,
                removeButton,
                addRemoveController);
        }
    }
}

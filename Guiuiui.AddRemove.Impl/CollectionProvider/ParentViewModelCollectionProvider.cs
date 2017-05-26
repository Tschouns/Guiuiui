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
    using ViewModel;

    /// <summary>
    /// See <see cref="ICollectionProvider{TCollectionItem}"/>. Retrieves the collection from a view model.
    /// </summary>
    /// <typeparam name="TCollectionItem">
    /// Type of the items in the collection
    /// </typeparam>
    public class ParentViewModelCollectionProvider<TParentItem, TCollectionItem> : ICollectionProvider<TCollectionItem>
        where TParentItem : class
        where TCollectionItem : class
    {
        private readonly IViewModel<TParentItem> _parentViewModel;
        private readonly Func<TParentItem, ICollection<TCollectionItem>> _getCollectionFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentViewModelCollectionProvider{TParentItem, TCollectionItem}"/> class.
        /// </summary>
        public ParentViewModelCollectionProvider(
            IViewModel<TParentItem> parentViewModel,
            Func<TParentItem, ICollection<TCollectionItem>> getCollectionFunc)
        {
            ArgumentChecks.AssertNotNull(parentViewModel, nameof(parentViewModel));
            ArgumentChecks.AssertNotNull(getCollectionFunc, nameof(getCollectionFunc));

            this._parentViewModel = parentViewModel;
            this._getCollectionFunc = getCollectionFunc;

            this._parentViewModel.ModelChanged += this.ParentViewModel_ModelChanged;
        }

        /// <summary>
        /// See <see cref="ICollectionProvider{TCollectionItem}.CollectionChanged"/>.
        /// </summary>
        public event EventHandler CollectionChanged;

        /// <summary>
        /// See <see cref="ICollectionProvider{TCollectionItem}.Collection"/>.
        /// </summary>
        public ICollection<TCollectionItem> Collection
        {
            get
            {
                if (this._parentViewModel.Model == null)
                {
                    return null;
                }

                return this._getCollectionFunc(this._parentViewModel.Model);
            }
        }

        private void ParentViewModel_ModelChanged(object sender, EventArgs e)
        {
            this.CollectionChanged?.Invoke(this, new EventArgs());
        }
    }
}

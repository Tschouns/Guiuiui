//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using System;
    using System.Collections.Generic;
    using Guiuiui.AddRemove;
    using ViewModel.List;

    /// <summary>
    /// Wrapps an <see cref="ISelection{TListItem}"/> object implements <see cref="IItemProvider{TItem}"/>.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class SelectionWrapper<TItem> : IItemProvider<TItem>
        where TItem : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionWrapper{TItem}"/> class.
        /// </summary>
        public SelectionWrapper(ISelection<TItem> selection)
        {
            throw new NotImplementedException();
        }

        public bool IsRetrievePossible
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler StateChanged;

        public IEnumerable<TItem> RetrieveItems()
        {
            throw new NotImplementedException();
        }
    }
}

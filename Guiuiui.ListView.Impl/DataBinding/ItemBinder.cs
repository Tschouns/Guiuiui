//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Guiuiui.Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="IItemBinder"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public class ItemBinder<TListItem> : IItemBinder
    {
        private readonly IEnumerable<IColumnBinding> _columnBindings;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBinder{TListItem}"/> class.
        /// </summary>
        public ItemBinder(
            IEnumerable<IColumnBinding> columnBindings)
        {
            ArgumentChecks.AssertNotNull(columnBindings, nameof(columnBindings));

            this._columnBindings = columnBindings;
        }

        /// <summary>
        /// See <see cref="IItemBinder.IsBound"/>.
        /// </summary>
        public bool IsBound => this._columnBindings.Any(b => b.IsBound);

        /// <summary>
        /// See <see cref="IItemBinder.UnbindAll"/>.
        /// </summary>
        public void UnbindAll()
        {
            if (this.IsBound)
            {
                foreach (var columnBinding in this._columnBindings)
                {
                    columnBinding.Unbind();
                }
            }
        }

        /// <summary>
        /// See <see cref="IItemBinder.UpdateColumns"/>.
        /// </summary>
        public void UpdateColumns()
        {
            foreach (var columnBinding in this._columnBindings)
            {
                columnBinding.Unbind();
            }
        }
    }
}

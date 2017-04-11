//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using System.Collections.Generic;
    using Guiuiui.Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="IItemBinder"/>.
    /// </summary>
    public class ItemBinder : IItemBinder
    {
        private readonly IEnumerable<ICellBinding> _cellBindings;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBinder{TListItem}"/> class.
        /// </summary>
        public ItemBinder(
            IEnumerable<ICellBinding> cellBindings)
        {
            ArgumentChecks.AssertNotNull(cellBindings, nameof(cellBindings));

            this._cellBindings = cellBindings;
        }

        /// <summary>
        /// See <see cref="IItemBinder.UpdateCells"/>.
        /// </summary>
        public void UpdateCells()
        {
            foreach (var cellBinding in this._cellBindings)
            {
                cellBinding.UpdateCell();
            }
        }
    }
}

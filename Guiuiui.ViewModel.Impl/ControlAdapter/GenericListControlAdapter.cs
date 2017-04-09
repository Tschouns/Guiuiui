//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using Base.RuntimeChecks;
    using List;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public class GenericListControlAdapter<TListItem> : IControlAdapter<IEnumerable<TListItem>>
    {
        private readonly IListControl<TListItem> _listControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericListControlAdapter{TListItem}"/> class.
        /// </summary>
        public GenericListControlAdapter(IListControl<TListItem> listControl)
        {
            ArgumentChecks.AssertNotNull(listControl, nameof(listControl));

            this._listControl = listControl;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.ControlValueChanged"/>. With list controls this is never raised.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>. The getter always returns an empty set.
        /// </summary>
        public IEnumerable<TListItem> Value
        {
            get
            {
                return new TListItem[0];
            }

            set
            {
                if (value == null)
                {
                    this._listControl.SetItemsToDisplay(new TListItem[0]);
                }
                else
                {
                    this._listControl.SetItemsToDisplay(value);
                }
            }
        }

    }
}

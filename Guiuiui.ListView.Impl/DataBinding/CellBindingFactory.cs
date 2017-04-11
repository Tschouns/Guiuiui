//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using Base.RuntimeChecks;
    using System;
    using Tools.TextConverter;

    /// <summary>
    /// See <see cref="ICellBindingFactory{TListItem}"/>.
    /// </summary>
    public class CellBindingFactory<TListItem, TPropertyValue> : ICellBindingFactory<TListItem>
    {
        private readonly ITextConverter<TPropertyValue> _textConverter;
        private readonly Func<TListItem, TPropertyValue> _getFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="CellBindingFactory{TListItem, TPropertyValue}"/> class.
        /// </summary>
        public CellBindingFactory(
            ITextConverter<TPropertyValue> textConverter,
            Func<TListItem, TPropertyValue> getFunc)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            this._textConverter = textConverter;
            this._getFunc = getFunc;
        }

        /// <summary>
        /// See <see cref="ICellBindingFactory{TListItem}.CreateCellBindingForItem(TListItem, ICell)"/>.
        /// </summary>
        public ICellBinding CreateCellBindingForItem(TListItem listItem, ICell cell)
        {
            ArgumentChecks.AssertNotNull(listItem, nameof(listItem));
            ArgumentChecks.AssertNotNull(cell, nameof(cell));

            var getter = new ListItemGetter<TListItem, TPropertyValue>(listItem, this._getFunc);
            var cellBinding = new CellBinding<TPropertyValue>(this._textConverter, getter, cell);

            return cellBinding;
        }
    }
}

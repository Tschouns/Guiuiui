//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using Base.RuntimeChecks;
    using System;

    /// <summary>
    /// See <see cref="IGetter{TPropertyValue}"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    /// <typeparam name="TPropertyValue">
    /// See <see cref="IGetter{TPropertyValue}"/>.
    /// </typeparam>
    public class ListItemGetter<TListItem, TPropertyValue> : IGetter<TPropertyValue>
    {
        private readonly TListItem _listItemNullsafe;
        private readonly Func<TListItem, TPropertyValue> _getFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemGetter"/> class.
        /// </summary>
        public ListItemGetter(
            TListItem listItemNullsafe,
            Func<TListItem, TPropertyValue> getFunc)
        {
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            this._listItemNullsafe = listItemNullsafe;
            this._getFunc = getFunc;
        }

        /// <summary>
        /// See <see cref="IGetter{TPropertyValue}"/>.
        /// </summary>
        public TPropertyValue Get()
        {
            if (this._listItemNullsafe == null)
            {
                return default(TPropertyValue);
            }

            var value = this._getFunc(this._listItemNullsafe);

            return value;
        }
    }
}
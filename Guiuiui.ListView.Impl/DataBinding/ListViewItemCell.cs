//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using Guiuiui.Base.RuntimeChecks;
    using System.Windows.Forms;
    using System;

    /// <summary>
    /// See <see cref="ICell"/>. Wraps a <see cref="ListViewItem"/>.
    /// </summary>
    public class ListViewItemCell : ICell
    {
        private readonly ListViewItem _listViewItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewItemCell"/> class.
        /// </summary>
        public ListViewItemCell(ListViewItem listViewItem)
        {
            ArgumentChecks.AssertNotNull(listViewItem, nameof(listViewItem));

            this._listViewItem = listViewItem;
        }

        /// <summary>
        /// See <see cref="ICell.SetText(string)"/>.
        /// </summary>
        public void SetText(string text)
        {
            ArgumentChecks.AssertNotNull(text, nameof(text));

            this._listViewItem.Text = text;
        }
    }
}

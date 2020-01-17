//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using Guiuiui.Base.RuntimeChecks;
    using static System.Windows.Forms.ListViewItem;

    /// <summary>
    /// See <see cref="ICell"/>. Wraps a <see cref="ListViewSubItem"/>.
    /// </summary>
    public class ListViewSubItemCell : ICell
    {
        private readonly ListViewSubItem _listViewSubItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewSubItemCell"/> class.
        /// </summary>
        public ListViewSubItemCell(ListViewSubItem listViewSubItem)
        {
            ArgumentChecks.AssertNotNull(listViewSubItem, nameof(listViewSubItem));

            this._listViewSubItem = listViewSubItem;
        }

        /// <summary>
        /// See <see cref="ICell.SetText(string)"/>.
        /// </summary>
        public void SetText(string text)
        {
            ArgumentChecks.AssertNotNull(text, nameof(text));

            this._listViewSubItem.Text = text;
        }
    }
}

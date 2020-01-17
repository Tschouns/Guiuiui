//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl
{
    using Base.RuntimeChecks;
    using System.Windows.Forms;
    using Tools.TextConverter;

    /// <summary>
    /// See <see cref="IListViewFactory"/>.
    /// </summary>
    public class ListViewFactory : IListViewFactory
    {
        /// <summary>
        /// Used by the <see cref="ListView{TListItem}"/> instances created by this class.
        /// </summary>
        private readonly ITextConverterProvider _textConverterProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewFactory"/> class.
        /// </summary>
        public ListViewFactory(ITextConverterProvider textConverterProvider)
        {
            ArgumentChecks.AssertNotNull(textConverterProvider, nameof(textConverterProvider));

            this._textConverterProvider = textConverterProvider;
        }

        /// <summary>
        /// See <see cref="IListViewFactory.Create{TListItem}"/>.
        /// </summary>
        /// <typeparam name="TListItem">
        /// See <see cref="IListViewFactory.Create{TListItem}"/>.
        /// </typeparam>
        public IListView<TListItem> Create<TListItem>(ListView listView)
            where TListItem : class
        {
            ArgumentChecks.AssertNotNull(listView, nameof(listView));

            var newListView = new ListView<TListItem>(listView, this._textConverterProvider);

            return newListView;
        }
    }
}

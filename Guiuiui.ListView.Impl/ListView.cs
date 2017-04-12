//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.ListView.DataBinding;
    using DataBinding;
    using Tools;
    using static System.Windows.Forms.ListViewItem;
    using ViewModel;

    /// <summary>
    /// See <see cref="IListView{TListItem}"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// See <see cref="IListView{TListItem}"/>.
    /// </typeparam>
    public class ListView<TListItem> : IListView<TListItem>
        where TListItem : class
    {
        private readonly ListView _listView;

        private readonly ICellBindingFactory<TListItem> _defaultColumnBinding;
        private readonly IList<ICellBindingFactory<TListItem>> _columnBindings = new List<ICellBindingFactory<TListItem>>();

        private readonly IList<IViewModel<TListItem>> _selectedItemViewModels = new List<IViewModel<TListItem>>();

        private readonly IList<IItemBinder> _itemBinders = new List<IItemBinder>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListView{TListItem}"/> class.
        /// </summary>
        public ListView(ListView listView)
        {
            ArgumentChecks.AssertNotNull(listView, nameof(listView));

            this._listView = listView;
            this._listView.SelectedIndexChanged += this.ListView_SelectedIndexChanged;

            // The "default column binding" is used, if no specific column bindins are defined.
            var textConverter = BaseToolBox.TextConverters.GetTextConverter<TListItem>();
            this._defaultColumnBinding = new CellBindingFactory<TListItem, TListItem>(textConverter, i => i);
        }

        /// <summary>
        /// See <see cref="IListControl{TListItem}.SetItemsToDisplay"/>.
        /// </summary>
        public void SetListItemsToDisplay(IEnumerable<TListItem> listItems)
        {
            ArgumentChecks.AssertNotNull(listItems, nameof(listItems));

            // TODO: Perhaps optimize this... so that the list is not cleared entirely...
            var selectedIndices = this._listView.SelectedIndices.Cast<int>().ToList();

            this._listView.Items.Clear();
            this._itemBinders.Clear();

            foreach(var listItem in listItems)
            {
                this.AddListViewItemWithSubItems(listItem);
            }

            foreach (var itemBinder in this._itemBinders)
            {
                itemBinder.UpdateCells();
            }
        }

        /// <summary>
        /// See <see cref="IBindableColumns{TListItem}.AddColumnBindingForProperty{TPropertyValue}"/>.
        /// </summary>
        public IBindableColumns<TListItem> AddColumnBindingForProperty<TPropertyValue>(Func<TListItem, TPropertyValue> getFunc)
        {
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            var textConverter = BaseToolBox.TextConverters.GetTextConverter<TPropertyValue>();
            var cellBindingFactory = new CellBindingFactory<TListItem, TPropertyValue>(textConverter, getFunc);
            this._columnBindings.Add(cellBindingFactory);

            return this;
        }

        /// <summary>
        /// See <see cref="IBindableColumns{TListItem}.UnbindAll"/>.
        /// </summary>
        public void UnbindAll()
        {
            this._columnBindings.Clear();
            this._itemBinders.Clear();
            this._listView.Items.Clear();
        }

        /// <summary>
        /// See <see cref="IHasItemViewModels{TListItem}.AddViewModelForSelectedItem(IViewModel{TListItem})"/>.
        /// </summary>
        public void AddViewModelForSelectedItem(IViewModel<TListItem> viewModel)
        {
            ArgumentChecks.AssertNotNull(viewModel, nameof(viewModel));

            viewModel.ValueChanged += this.ViewModel_ValueChanged;

            this._selectedItemViewModels.Add(viewModel);
        }

        private void AddListViewItemWithSubItems(TListItem listItemNullsafe)
        {
            var listViewItem = new ListViewItem();

            // The actual item is stored in the ListViewItem tag.
            listViewItem.Tag = listItemNullsafe;

            var cellBindings = this.CreateCellBindings(listItemNullsafe, listViewItem);
            var itemBinder = new ItemBinder(cellBindings);

            this._listView.Items.Add(listViewItem);
            this._itemBinders.Add(itemBinder);
        }

        private IEnumerable<ICellBinding> CreateCellBindings(
            TListItem listItemNullsafe,
            ListViewItem listViewItem)
        {
            ArgumentChecks.AssertNotNull(listViewItem, nameof(listViewItem));

            // The first column displays the ListViewItem.
            var firstCell = new ListViewItemCell(listViewItem);

            var cellBindings = new List<ICellBinding>();
            if (this._columnBindings.Any())
            {
                var firstCellBinding = this._columnBindings.First().CreateCellBindingForItem(listItemNullsafe, firstCell);

                cellBindings.Add(firstCellBinding);

                // The subsequent columns (if there are any) display a ListViewSubItem each.
                var subsequentColumnBindings = this._columnBindings.Skip(1).ToList();
                foreach (var columnBinding in subsequentColumnBindings)
                {
                    var listViewSubItem = new ListViewSubItem(listViewItem, string.Empty);
                    listViewItem.SubItems.Add(listViewSubItem);

                    var cell = new ListViewSubItemCell(listViewSubItem);
                    var cellBinding = columnBinding.CreateCellBindingForItem(listItemNullsafe, cell);

                    cellBindings.Add(cellBinding);
                }
            }
            else
            {
                var firstCellBinding = this._defaultColumnBinding.CreateCellBindingForItem(listItemNullsafe, firstCell);

                cellBindings.Add(firstCellBinding);
            }

            return cellBindings;
        }

        #region event handlers

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedListItems = this._listView.SelectedItems
                .Cast<ListViewItem>()
                .Select(i => i.Tag)
                .OfType<TListItem>()
                .ToList();

            // Clear view model(s).
            foreach (var viewModel in this._selectedItemViewModels)
            {
                viewModel.Model = null;
            }

            // Populate view model(s) with selected item(s).
            for (var index = 0; index < selectedListItems.Count; index++)
            {
                if (this._selectedItemViewModels.Count > index)
                {
                    this._selectedItemViewModels[index].Model = selectedListItems[index];
                }
            }
        }

        private void ViewModel_ValueChanged(object sender, EventArgs e)
        {
            foreach(var itemBinder in this._itemBinders)
            {
                itemBinder.UpdateCells();
            }
        }

        #endregion
    }
}

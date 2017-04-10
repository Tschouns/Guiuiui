//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl
{
    using System;
    using System.Collections.Generic;
    using Guiuiui.ListView.DataBinding;

    public class ListView<TListItem> : IListView<TListItem>
    {
        public void SetItemsToDisplay(IEnumerable<TListItem> items)
        {
            throw new NotImplementedException();
        }

        public IBindableColumns<TListItem> AddColumnBindingForProperty<TPropertyValue>(Func<TListItem, TPropertyValue> getFunc)
        {
            throw new NotImplementedException();
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.DataBinding
{
    using System;
    using Guiuiui.ViewModel.DataBinding;
    using List;
    using ControlAdapter;
    using System.Collections.Generic;
    using Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="IListPropertyPredicate{TListItem}"/>.
    /// </summary>
    /// <typeparam name="TListItem">
    /// See <see cref="IListPropertyPredicate{TListItem}"/>.
    /// </typeparam>
    public class ListPropertyPredicate<TModel, TListItem> : IListPropertyPredicate<TListItem>
        where TModel : class
    {
        private readonly IControlAdapterFactory _controlAdapterFactory;

        // These fields are needed to create the data binding.
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<IEnumerable<TListItem>> _getter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IDataBinding> _addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPropertyPredicate{TListItem}"/> class.
        /// </summary>
        public ListPropertyPredicate(
            IControlAdapterFactory controlAdapterFactory,
            INotifyOnValueChanged model,
            IGetter<IEnumerable<TListItem>> getter,
            Action<IDataBinding> addDataBindingCallback)
        {
            ArgumentChecks.AssertNotNull(controlAdapterFactory, nameof(controlAdapterFactory));
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(addDataBindingCallback, nameof(addDataBindingCallback));

            this._controlAdapterFactory = controlAdapterFactory;
            this._model = model;
            this._getter = getter;
            this._addDataBindingCallback = addDataBindingCallback;
        }

        /// <summary>
        /// See <see cref="IListPropertyPredicate{TListItem}.ToListControl(IListControl{TListItem})"/>.
        /// </summary>
        public void ToListControl(IListControl<TListItem> listControl)
        {
            ArgumentChecks.AssertNotNull(listControl, nameof(listControl));

            var listControlAdapter = this._controlAdapterFactory.CreateListControlAdapter(listControl);
            var dataBinding = new ReadOnlyDataBinding<IEnumerable<TListItem>>(this._model, this._getter, listControlAdapter);

            this._addDataBindingCallback(dataBinding);
        }
    }
}

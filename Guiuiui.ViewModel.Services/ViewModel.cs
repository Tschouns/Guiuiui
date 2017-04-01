﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services
{
    using System;
    using Guiuiui.ViewModel.DataBinding;
    using DataBinding;
    using System.Collections;
    using System.Collections.Generic;
    using Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="IViewModel{TModel}"/>.
    /// </summary>
    /// <typeparam name="TModel">
    /// See <see cref="IViewModel{TModel}"/>.
    /// </typeparam>
    public class ViewModel<TModel> : IViewModel<TModel>
        where TModel : class
    {
        private readonly IList<IDataBinding> _dataBindings = new List<IDataBinding>();
        private TModel _model = null;

        /// <summary>
        /// See <see cref="INotifyOnValueChanged.ValueChanged"/>.
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// See <see cref="IViewModel{TModel}.Model"/>.
        /// </summary>
        public TModel Model
        {
            get { return this._model; }
            set
            {
                this._model = value;
                this.OnValueChanged();
            }
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindPropertyGet{TPropertyValue}(Func{TModel, TPropertyValue})"/>.
        /// </summary>
        public IReadOnlyPropertyPredicate BindPropertyGet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc)
        {
            var getter = new ViewModelGetter<TModel, TPropertyValue>(this, getFunc);
            var predicate = new ReadOnlyPropertyPredicate<TModel, TPropertyValue>(this, getter, this.AddDataBidning);

            return predicate;
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindPropertyGetAndSet{TPropertyValue}(Func{TModel, TPropertyValue}, Action{TModel, TPropertyValue})"/>.
        /// </summary>
        public ITwoWayPropertyPredicate BindPropertyGetAndSet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TModel, TPropertyValue> setAction)
        {
            var getter = new ViewModelGetter<TModel, TPropertyValue>(this, getFunc);
            var setter = new ViewModelSetter<TModel, TPropertyValue>(this, setAction);
            var predicate = new TwoWayPropertyPredicate<TModel, TPropertyValue>(this, getter, setter, this.AddDataBidning);

            return predicate;
        }

        /// <summary>
        /// See <see cref="INotifiable.NotifyValueHasChanged"/>.
        /// </summary>
        public void NotifyValueHasChanged()
        {
            this.OnValueChanged();
        }

        /// <summary>
        /// Call-back method, adds a new data binding.
        /// </summary>
        private void AddDataBidning(IDataBinding dataBinding)
        {
            ArgumentChecks.AssertNotNull(dataBinding, nameof(dataBinding));

            this._dataBindings.Add(dataBinding);
        }

        /// <summary>
        /// Raises the <see cref="INotifyOnValueChanged.ValueChanged"/> event.
        /// </summary>
        private void OnValueChanged()
        {
            this.ValueChanged?.Invoke(this, new EventArgs());
        }
    }
}

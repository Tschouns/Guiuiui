﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services
{
    using System;
    using Guiuiui.ViewModel.DataBinding;

    /// <summary>
    /// See <see cref="IViewModel{TModel}"/>.
    /// </summary>
    /// <typeparam name="TModel">
    /// See <see cref="IViewModel{TModel}"/>.
    /// </typeparam>
    public class ViewModel<TModel> : IViewModel<TModel>
        where TModel : class
    {
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
        public IPropertyPredicate BindPropertyGet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindPropertyGetAndSet{TPropertyValue}(Func{TModel, TPropertyValue}, Action{TPropertyValue, TModel})"/>.
        /// </summary>
        public IPropertyPredicate BindPropertyGetAndSet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TPropertyValue, TModel> SetAction)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="INotifiable.NotifyValueHasChanged"/>.
        /// </summary>
        public void NotifyValueHasChanged()
        {
            this.OnValueChanged();
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

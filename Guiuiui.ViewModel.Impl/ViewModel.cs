//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl
{
    using System;
    using Guiuiui.ViewModel.DataBinding;
    using DataBinding;
    using System.Collections.Generic;
    using Base.RuntimeChecks;
    using ControlAdapter;

    /// <summary>
    /// See <see cref="IViewModel{TModel}"/>.
    /// </summary>
    /// <typeparam name="TModel">
    /// See <see cref="IViewModel{TModel}"/>.
    /// </typeparam>
    public class ViewModel<TModel> : IViewModel<TModel>
        where TModel : class
    {
        private readonly IControlAdapterFactory _controlAdapterFactory;
        private readonly IList<IDataBinding> _dataBindings = new List<IDataBinding>();
        private TModel _model = null;

        /// <summary>
        /// See <see cref="INotifyOnValueChanged.ValueChanged"/>.
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel{TModel}"/> class.
        /// </summary>
        public ViewModel(IControlAdapterFactory controlAdapterFactory)
        {
            ArgumentChecks.AssertNotNull(controlAdapterFactory, nameof(controlAdapterFactory));

            this._controlAdapterFactory = controlAdapterFactory;
        }

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
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            var getter = new ViewModelGetter<TModel, TPropertyValue>(this, getFunc);
            var predicate = new ReadOnlyPropertyPredicate<TModel, TPropertyValue>(this._controlAdapterFactory, this, getter, this.AddDataBidning);

            return predicate;
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindPropertyGetAndSet{TPropertyValue}(Func{TModel, TPropertyValue}, Action{TModel, TPropertyValue})"/>.
        /// </summary>
        public ITwoWayPropertyPredicate BindPropertyGetAndSet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TModel, TPropertyValue> setAction)
        {
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));
            ArgumentChecks.AssertNotNull(setAction, nameof(setAction));

            var getter = new ViewModelGetter<TModel, TPropertyValue>(this, getFunc);
            var setter = new ViewModelSetter<TModel, TPropertyValue>(this, setAction);
            var predicate = new TwoWayPropertyPredicate<TModel, TPropertyValue>(this._controlAdapterFactory, this, getter, setter, this.AddDataBidning);

            return predicate;
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindListProperty{TListItem}(Func{TModel, IEnumerable{TListItem}})"/>.
        /// </summary>
        public IListPropertyPredicate<TListItem> BindListProperty<TListItem>(Func<TModel, IEnumerable<TListItem>> getFunc)
        {
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            var getter = new ViewModelGetter<TModel, IEnumerable<TListItem>>(this, getFunc);
            var predicate = new ListPropertyPredicate<TModel, TListItem>(this._controlAdapterFactory, this, getter, this.AddDataBidning);

            return predicate;
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.UnbindAll"/>.
        /// </summary>
        public void UnbindAll()
        {
            foreach(var dataBinding in this._dataBindings)
            {
                dataBinding.Unbind();
            }

            this._dataBindings.Clear();
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

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.DataBinding
{
    using Base.InversionOfControl;
    using Base.RuntimeChecks;
    using ControlAdapter;
    using Guiuiui.ViewModel.DataBinding;
    using System;
    using System.Windows.Forms;
    using ViewModel.Parser;

    /// <summary>
    /// Implementation of the <see cref="IReadOnlyPropertyPredicate"/>. Creates the actual data binding.
    /// </summary>
    public class TwoWayPropertyPredicate<TModel, TPropertyValue> : ITwoWayPropertyPredicate
        where TModel : class
    {
        // These fields are needed to create the data binding.
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<TPropertyValue> _getter;
        private readonly ISetter<TPropertyValue> _setter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IDataBinding> _addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoWayPropertyPredicate{TModel,TPropertyValue}"/> class.
        /// </summary>
        public TwoWayPropertyPredicate(
            INotifyOnValueChanged model,
            IGetter<TPropertyValue> getter,
            ISetter<TPropertyValue> setter,
            Action<IDataBinding> addDataBindingCallback)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(setter, nameof(setter));
            ArgumentChecks.AssertNotNull(addDataBindingCallback, nameof(addDataBindingCallback));

            this._model = model;
            this._getter = getter;
            this._setter = setter;
            this._addDataBindingCallback = addDataBindingCallback;
        }

        /// <summary>
        /// See <see cref="IReadOnlyPropertyPredicate.ToComboBox(ComboBox)"/>.
        /// </summary>
        public void ToComboBox(ComboBox comboBox)
        {
            // TODO: put this in a factory:
            var comboBoxAdapter = new GenericComboBoxAdapter<TPropertyValue>(comboBox);
            var dataBinding = new TwoWayDataBinding<TPropertyValue>(this._model, this._getter, this._setter, comboBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }

        /// <summary>
        /// See <see cref="IReadOnlyPropertyPredicate.ToTextBox(TextBox)"/>.
        /// </summary>
        public void ToTextBox(TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            // TODO: put this in a factory:
            var parser = Ioc.Container.Resolve<IParser<TPropertyValue>>();
            var textBoxAdapter = new GenericTextBoxAdapter<TPropertyValue>(parser, textBox);
            var dataBinding = new TwoWayDataBinding<TPropertyValue>(this._model, this._getter, this._setter, textBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.DataBinding
{
    using Base.InversionOfControl;
    using Base.RuntimeChecks;
    using ControlAdapter;
    using Guiuiui.ViewModel.DataBinding;
    using System;
    using System.Windows.Forms;
    using ViewModel.Conversion;

    /// <summary>
    /// Implementation of the <see cref="IPropertyPredicate"/>. Creates the actual data binding.
    /// </summary>
    public class ReadOnlyPropertyPredicate<TModel, TPropertyValue> : IPropertyPredicate
        where TModel : class
    {
        // These fields are needed to create the data binding.
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<TPropertyValue> _getter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IDataBinding> _addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoWayPropertyPredicate{TModel,TPropertyValue}"/> class.
        /// </summary>
        public ReadOnlyPropertyPredicate(
            INotifyOnValueChanged model,
            IGetter<TPropertyValue> getter,
            Action<IDataBinding> addDataBindingCallback)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(addDataBindingCallback, nameof(addDataBindingCallback));

            this._model = model;
            this._getter = getter;
            this._addDataBindingCallback = addDataBindingCallback;
        }

        /// <summary>
        /// See <see cref="IPropertyPredicate.ToComboBox(ComboBox)"/>.
        /// </summary>
        public void ToComboBox(ComboBox comboBox)
        {
            // TODO: put this in a factory:
            var comboBoxAdapter = new GenericComboBoxAdapter<TPropertyValue>(comboBox);

            var dataBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, comboBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }

        /// <summary>
        /// See <see cref="IPropertyPredicate.ToTextBox(TextBox)"/>.
        /// </summary>
        public void ToTextBox(TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            // TODO: put this in a factory:
            var conversion = Ioc.Container.Resolve<IConversion<string, TPropertyValue>>();
            var textBoxAdapter = new GenericTextBoxAdapter<TPropertyValue>(conversion, textBox);

            var dataBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, textBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.DataBinding
{
    using Base.RuntimeChecks;
    using ControlAdapter;
    using Guiuiui.ViewModel.DataBinding;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Implementation of the <see cref="IReadOnlyPropertyPredicate"/>. Creates the actual data binding.
    /// </summary>
    public class ReadOnlyPropertyPredicate<TModel, TPropertyValue> : IReadOnlyPropertyPredicate
        where TModel : class
    {
        private readonly IControlAdapterFactory _controlAdapterFactory;

        // These fields are needed to create the data binding.
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<TPropertyValue> _getter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IDataBinding> _addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyPropertyPredicate{TModel, TPropertyValue}"/> class.
        /// </summary>
        public ReadOnlyPropertyPredicate(
            IControlAdapterFactory controlAdapterFactory,
            INotifyOnValueChanged model,
            IGetter<TPropertyValue> getter,
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
        /// See <see cref="IReadOnlyPropertyPredicate.ToLabel(Label)"/>.
        /// </summary>
        public void ToLabel(Label label)
        {
            ArgumentChecks.AssertNotNull(label, nameof(label));

            var labelAdapter = this._controlAdapterFactory.CreateLabelAdapter<TPropertyValue>(label);
            var dataBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, labelAdapter);

            this._addDataBindingCallback(dataBinding);
        }

        /// <summary>
        /// See <see cref="IReadOnlyPropertyPredicate.ToTextBox(TextBox)"/>.
        /// </summary>
        public void ToTextBox(TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            var textBoxAdapter = this._controlAdapterFactory.CreateTextBoxAdapter<TPropertyValue>(textBox);
            var dataBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, textBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }

        /// <summary>
        /// See <see cref="IReadOnlyPropertyPredicate.ToComboBox(ComboBox)"/>.
        /// </summary>
        public void ToComboBox(ComboBox comboBox)
        {
            ArgumentChecks.AssertNotNull(comboBox, nameof(comboBox));

            var comboBoxAdapter = this._controlAdapterFactory.CreateComboBoxAdapter<TPropertyValue>(comboBox);
            var dataBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, comboBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }

        /// <summary>
        /// See <see cref="IReadOnlyPropertyPredicate.ToCheckBox(CheckBox)"/>.
        /// </summary>
        public void ToCheckBox(CheckBox checkBox)
        {
            ArgumentChecks.AssertNotNull(checkBox, nameof(checkBox));

            var checkBoxAdapter = this._controlAdapterFactory.CreateCheckBoxAdapter<TPropertyValue>(checkBox);
            var dataBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, checkBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }

        /// <summary>
        /// See <see cref="IReadOnlyPropertyPredicate.ToDateTimePicker(DateTimePicker)"/>.
        /// </summary>
        public void ToDateTimePicker(DateTimePicker dateTimePicker)
        {
            ArgumentChecks.AssertNotNull(dateTimePicker, nameof(dateTimePicker));

            var dateTimePickerAdapter = this._controlAdapterFactory.CreateDateTimePickerAdapter<TPropertyValue>(dateTimePicker);
            var dateBinding = new ReadOnlyDataBinding<TPropertyValue>(this._model, this._getter, dateTimePickerAdapter);

            this._addDataBindingCallback(dateBinding);
        }
    }
}

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
    public class PropertyPredicate<TModel, TPropertyValue> : IPropertyPredicate
        where TModel : class
    {
        // These fields are needed to create the data binding.
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<TPropertyValue> _getter;
        private readonly ISetter<TPropertyValue> _setter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IDataBinding> _addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyPredicate{TModel, TPropertyValue}"/> class.
        /// </summary>
        public PropertyPredicate(
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
        /// See <see cref="IPropertyPredicate.ToComboBox(ComboBox)"/>.
        /// </summary>
        public void ToComboBox(ComboBox ComboBox)
        {
            throw new NotImplementedException();
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

            var dataBinding = new DataBinding<TPropertyValue>(this._model, this._getter, this._setter, textBoxAdapter);

            this._addDataBindingCallback(dataBinding);
        }
    }
}

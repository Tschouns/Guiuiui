﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using Base.RuntimeChecks;
    using System.Windows.Forms;
    using System;
    using ViewModel.DataBinding;
    using System.Globalization;
    using List;
    using System.Collections.Generic;
    using Tools.TextConverter;
    using Tools.Parser;

    /// <summary>
    /// See <see cref="IControlAdapterFactory"/>.
    /// </summary>
    public class ControlAdapterFactory : IControlAdapterFactory
    {
        private readonly ITextConverterProvider _textConverterProvider;
        private readonly IParserProvider _parserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlAdapterFactory"/> class.
        /// </summary>
        public ControlAdapterFactory(
            ITextConverterProvider textConverterProvider,
            IParserProvider parserProvider)
        {
            ArgumentChecks.AssertNotNull(textConverterProvider, nameof(textConverterProvider));
            ArgumentChecks.AssertNotNull(parserProvider, nameof(parserProvider));

            this._textConverterProvider = textConverterProvider;
            this._parserProvider = parserProvider;
        }

        /// <summary>
        /// See <see cref="IControlAdapterFactory.CreateLabelAdapter{TValue}(Label)"/>.
        /// </summary>
        public IControlAdapter<TValue> CreateLabelAdapter<TValue>(Label label)
        {
            ArgumentChecks.AssertNotNull(label, nameof(label));

            var textConverter = this._textConverterProvider.GetTextConverter<TValue>();

            return new GenericLabelAdapter<TValue>(textConverter, label);
        }

        /// <summary>
        /// See <see cref="IControlAdapterFactory.CreateTextBoxAdapter{TValue}(TextBox)"/>.
        /// </summary>
        public IControlAdapter<TValue> CreateTextBoxAdapter<TValue>(TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            var textConverter = this._textConverterProvider.GetTextConverter<TValue>();
            var parser = this._parserProvider.GetParser<TValue>();

            return new GenericTextBoxAdapter<TValue>(textConverter, parser, textBox);
        }

        /// <summary>
        /// See <see cref="IControlAdapterFactory.CreateComboBoxAdapter{TValue}(ComboBox)"/>.
        /// </summary>
        public IControlAdapter<TValue> CreateComboBoxAdapter<TValue>(ComboBox comboBox)
        {
            ArgumentChecks.AssertNotNull(comboBox, nameof(comboBox));

            var textConverter = this._textConverterProvider.GetTextConverter<TValue>();

            return new GenericComboBoxAdapter<TValue>(textConverter, comboBox);
        }

        /// <summary>
        /// See <see cref="IControlAdapterFactory.CreateComboBoxAdapter{TValue}(ComboBox)"/>.
        /// </summary>
        public IControlAdapter<TValue> CreateCheckBoxAdapter<TValue>(CheckBox checkBox)
        {
            ArgumentChecks.AssertNotNull(checkBox, nameof(checkBox));

            if (typeof(TValue) == typeof(bool))
            {
                var checkBoxAdapter = new CheckBoxAdapter(checkBox);

                return (IControlAdapter<TValue>)checkBoxAdapter;
            }

            // There is no suitable check box adapter for TValue.
            var message = string.Format(CultureInfo.CurrentCulture, ErrorMessages.PropertyTypeNotSupportedByCheckBox, typeof(TValue));

            throw new DataBindingErrorException(message);
        }

        /// <summary>
        /// See <see cref="IControlAdapterFactory.CreateDateTimePickerAdapter{TValue}(DateTimePicker)"/>.
        /// </summary>
        public IControlAdapter<TValue> CreateDateTimePickerAdapter<TValue>(DateTimePicker dateTimePicker)
        {
            ArgumentChecks.AssertNotNull(dateTimePicker, nameof(dateTimePicker));

            if (typeof (TValue) == typeof (DateTime))
            {
                var dateTimePickerAdapter = new DateTimePickerAdapter(dateTimePicker);

                return (IControlAdapter<TValue>)dateTimePickerAdapter;
            }

            // There is no suitable date time box adapter for TValue.
            var message = string.Format(CultureInfo.CurrentCulture, ErrorMessages.PropertyTypeNotSupportedByDateTimePicker, typeof(TValue));

            throw new DataBindingErrorException(message);
        }

        /// <summary>
        /// See <see cref="IControlAdapterFactory.CreateListControlAdapter{TListItem}(IListControl{TListItem})"/>.
        /// </summary>
        public IControlAdapter<IEnumerable<TListItem>> CreateListControlAdapter<TListItem>(IListControl<TListItem> listControl)
        {
            ArgumentChecks.AssertNotNull(listControl, nameof(listControl));

            return new GenericListControlAdapter<TListItem>(listControl);
        }
    }
}

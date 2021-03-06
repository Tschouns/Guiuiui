﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using List;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Creates control adapters for different controls.
    /// </summary>
    public interface IControlAdapterFactory
    {
        /// <summary>
        /// Creates a control adapter for a <see cref="Label"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value represented by the control
        /// </typeparam>
        IControlAdapter<TValue> CreateLabelAdapter<TValue>(Label label);

        /// <summary>
        /// Creates a control adapter for a <see cref="TextBox"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value represented by the control
        /// </typeparam>
        IControlAdapter<TValue> CreateTextBoxAdapter<TValue>(TextBox textBox);

        /// <summary>
        /// Creates a control adapter for a <see cref="ComboBox"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value represented by the control
        /// </typeparam>
        IControlAdapter<TValue> CreateComboBoxAdapter<TValue>(ComboBox comboBox);

        /// <summary>
        /// Creates a control adapter for a <see cref="CheckBox"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value represented by the control
        /// </typeparam>
        IControlAdapter<TValue> CreateCheckBoxAdapter<TValue>(CheckBox checkBox);

        /// <summary>
        /// Creates a control adapter for a <see cref="DateTimePicker"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value represented by the control
        /// </typeparam>
        IControlAdapter<TValue> CreateDateTimePickerAdapter<TValue>(DateTimePicker dateTimePicker);

        /// <summary>
        /// Creates a control adapter for a <see cref="IListControl{TListItem}"/>.
        /// </summary>
        /// <typeparam name="TListItem">
        /// Type of the list item
        /// </typeparam>
        IControlAdapter<IEnumerable<TListItem>> CreateListControlAdapter<TListItem>(IListControl<TListItem> listControl);
    }
}

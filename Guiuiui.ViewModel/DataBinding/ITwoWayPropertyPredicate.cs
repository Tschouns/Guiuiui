﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using System.Windows.Forms;

    /// <summary>
    /// Provides an interface to bind a control "two-way" to the property.
    /// </summary>
    public interface ITwoWayPropertyPredicate
    {
        /// <summary>
        /// Binds a text box to the property.
        /// </summary>
        void ToTextBox(TextBox textBox);

        /// <summary>
        /// Binds a combo box to the property.
        /// </summary>
        void ToComboBox(ComboBox comboBox);

        /// <summary>
        /// Binds a check box to the property.
        /// </summary>
        /// <param name="checkBox"></param>
        void ToCheckBox(CheckBox checkBox);

        /// <summary>
        /// Binds a date time picker to the property.
        /// </summary>
        void ToDateTimePicker(DateTimePicker dateTimePicker);
    }
}

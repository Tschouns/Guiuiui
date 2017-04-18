//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using System.Windows.Forms;

    /// <summary>
    /// Provides an interface to bind a control "read-only" to the property.
    /// </summary>
    public interface IReadOnlyPropertyPredicate
    {
        /// <summary>
        /// Binds the specified label to the property.
        /// </summary>
        void ToLabel(Label label);

        /// <summary>
        /// Binds the specified text box to the property.
        /// </summary>
        void ToTextBox(TextBox textBox);

        /// <summary>
        /// Binds the specified combo box to the property.
        /// </summary>
        void ToComboBox(ComboBox comboBox);

        /// <summary>
        /// Binds the specified check box to the property.
        /// </summary>
        /// <param name="checkBox"></param>
        void ToCheckBox(CheckBox checkBox);

        /// <summary>
        /// Binds a date time picker to the property.
        /// </summary>
        void ToDateTimePicker(DateTimePicker dateTimePicker);
    }
}

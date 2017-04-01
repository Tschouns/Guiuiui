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
        /// Binds a label to the property.
        /// </summary>
        void ToLabel(Label label);

        /// <summary>
        /// Binds a text box to the property.
        /// </summary>
        void ToTextBox(TextBox textBox);

        /// <summary>
        /// Binds a combo box to the property.
        /// </summary>
        void ToComboBox(ComboBox comboBox);
    }
}

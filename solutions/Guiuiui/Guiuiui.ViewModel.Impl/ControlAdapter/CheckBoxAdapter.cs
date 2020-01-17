//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using Base.RuntimeChecks;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    public class CheckBoxAdapter : IControlAdapter<bool>
    {
        private readonly CheckBox _checkBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxAdapter"/> class.
        /// </summary>
        public CheckBoxAdapter(CheckBox checkBox)
        {
            ArgumentChecks.AssertNotNull(checkBox, nameof(checkBox));

            this._checkBox = checkBox;
            this._checkBox.CheckedChanged += this.CheckBox_CheckedChanged;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>.
        /// </summary>
        public bool Value
        {
            get { return this._checkBox.Checked; }
            set { this._checkBox.Checked = value; }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }
    }
}

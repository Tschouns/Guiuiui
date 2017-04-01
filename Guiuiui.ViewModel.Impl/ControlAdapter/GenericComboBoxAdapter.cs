//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using Guiuiui.Base.RuntimeChecks;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericComboBoxAdapter<TValue> : IControlAdapter<TValue>
    {
        private readonly ComboBox _comboBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericComboBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericComboBoxAdapter(ComboBox comboBox)
        {
            ArgumentChecks.AssertNotNull(comboBox, nameof(comboBox));

            this._comboBox = comboBox;

            this._comboBox.SelectedValueChanged += this.ComboBox_SelectedValueChanged;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler<ControlValueChangedEventArgs<TValue>> ControlValueChanged;

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>.
        /// </summary>
        public TValue Value
        {
            get
            {
                return this.GetSelectedValue();
            }

            set
            {
                this._comboBox.SelectedItem = value;
            }
        }

        private TValue GetSelectedValue()
        {
            if (this._comboBox.SelectedItem is TValue)
            {
                return (TValue)this._comboBox.SelectedItem;
            }

            return default(TValue);
        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new ControlValueChangedEventArgs<TValue>(this));
        }
    }
}

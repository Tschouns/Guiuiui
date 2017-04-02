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
    using Tools.TextConverter;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericComboBoxAdapter<TValue> : IControlAdapter<TValue>
    {
        // TODO: create a "wrapper item" which contains the value and overrides "ToString".
        private readonly ITextConverter<TValue> _textConverter;
        private readonly ComboBox _comboBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericComboBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericComboBoxAdapter(
            ITextConverter<TValue> textConverter,
            ComboBox comboBox)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(comboBox, nameof(comboBox));

            this._textConverter = textConverter;
            this._comboBox = comboBox;

            this._comboBox.SelectedValueChanged += this.ComboBox_SelectedValueChanged;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler ControlValueChanged;

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
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }
    }
}

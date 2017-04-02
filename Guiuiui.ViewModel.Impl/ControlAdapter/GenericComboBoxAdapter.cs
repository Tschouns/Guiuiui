//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using Guiuiui.Base.RuntimeChecks;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Tools;
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
            this._comboBox.TextChanged += this.ComboBox_TextChanged;

            // Hack-a-doodle...
            this._comboBox.FormatInfo = GuiuiuiToolBox.CustomFormatProviders.CreateCustomFormatProvider<TValue>(
                GuiuiuiToolBox.Parsers.GetParser<TValue>(),
                this._textConverter);
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
                this.TrySetSelectedItem(value);
                this.SetText();
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

        private void TrySetSelectedItem(TValue value)
        {
            if (this._comboBox.Items.OfType<TValue>().Contains(value))
            {
                this._comboBox.SelectedItem = value;
            }
            else
            {
                this._comboBox.SelectedItem = null;
            }
        }

        private void SetText()
        {
            this._comboBox.TextChanged -= this.ComboBox_TextChanged;
            this._comboBox.Text = this._textConverter.GetText(this.Value);
            this._comboBox.TextChanged += this.ComboBox_TextChanged;
        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            var itemsMatchingText = this._comboBox.Items
                .OfType<TValue>()
                .Where(v => this._textConverter.GetText(v).ToLower() == this._comboBox.Text.ToLower())
                .ToList();

            if (itemsMatchingText.Count == 1)
            {
                this.TrySetSelectedItem(itemsMatchingText.Single());
                this.SetText();
                return;
            }

            var itemsContainingText = this._comboBox.Items
                .OfType<TValue>()
                .Where(v => this._textConverter.GetText(v).ToLower().Contains(this._comboBox.Text.ToLower()))
                .ToList();

            if (itemsContainingText.Count == 1)
            {
                this.TrySetSelectedItem(itemsContainingText.Single());
                this.SetText();
            }
        }
    }
}

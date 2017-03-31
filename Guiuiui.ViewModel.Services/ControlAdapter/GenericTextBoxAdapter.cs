//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.ControlAdapter
{
    using System;
    using System.Windows.Forms;
    using Guiuiui.Base.RuntimeChecks;
    using ViewModel.Conversion;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericTextBoxAdapter<TValue> : IControlAdapter<TValue>
    {
        private readonly IConversion<string, TValue> _textToValueConversion;
        private readonly TextBox _textBox;
        private TValue _currentValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericTextBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericTextBoxAdapter(
            IConversion<string, TValue> textToValueConversion,
            TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(textToValueConversion, nameof(textToValueConversion));
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            this._textToValueConversion = textToValueConversion;
            this._textBox = textBox;
            this._currentValue = this._textToValueConversion.TryConvert(textBox.Text).Result;

            this._textBox.TextChanged += this.TextBox_TextChanged;
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
                return this._textToValueConversion.TryConvert(this._textBox.Text).Result;
            }
            set
            {
                this._currentValue = value;

                this._textBox.Text = this._currentValue?.ToString();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var result = this._textToValueConversion.TryConvert(this._textBox.Text);
            if (result.IsSuccessful)
            {
                this._currentValue = result.Result;
                this.ControlValueChanged?.Invoke(this, new ControlValueChangedEventArgs<TValue>(this));
                return;
            }

            // If the conversion failed, the text is restored.
            this._textBox.Text = this._currentValue?.ToString();
        }
    }
}

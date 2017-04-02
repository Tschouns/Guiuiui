//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using System;
    using System.Windows.Forms;
    using Guiuiui.Base.RuntimeChecks;
    using Tools.Parser;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericTextBoxAdapter<TValue> : IControlAdapter<TValue>
    {
        private readonly IParser<TValue> _parser;
        private readonly TextBox _textBox;
        private TValue _currentValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericTextBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericTextBoxAdapter(
            IParser<TValue> parser,
            TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(parser, nameof(parser));
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            this._parser = parser;
            this._textBox = textBox;
            this._currentValue = this._parser.TryParse(textBox.Text).Result;

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
                return this._parser.TryParse(this._textBox.Text).Result;
            }
            set
            {
                this._currentValue = value;

                // TODO: create and use a "ITextConverter"
                this._textBox.Text = this._currentValue?.ToString();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var result = this._parser.TryParse(this._textBox.Text);
            if (result.IsSuccessful)
            {
                this._currentValue = result.Result;
                this.ControlValueChanged?.Invoke(this, new ControlValueChangedEventArgs<TValue>(this));
                return;
            }

            // If the conversion failed, the text is restored.
            // TODO: create and use a "ITextConverter"
            this._textBox.Text = this._currentValue?.ToString();
        }
    }
}

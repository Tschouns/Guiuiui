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
    using Tools.TextConverter;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericTextBoxAdapter<TValue> : IControlAdapter<TValue>
    {
        private readonly ITextConverter<TValue> _textConverter;
        private readonly IParser<TValue> _parser;
        private readonly TextBox _textBox;
        private TValue _currentValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericTextBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericTextBoxAdapter(
            ITextConverter<TValue> textConverter,
            IParser<TValue> parser,
            TextBox textBox)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(parser, nameof(parser));
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));

            this._textConverter = textConverter;
            this._parser = parser;
            this._textBox = textBox;
            this._currentValue = this._parser.TryParse(textBox.Text).Result;

            this._textBox.TextChanged += this.TextBox_TextChanged;
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
                return this._parser.TryParse(this._textBox.Text).Result;
            }
            set
            {
                this._currentValue = value;

                this._textBox.Text = this._textConverter.GetText(this._currentValue);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var result = this._parser.TryParse(this._textBox.Text);
            if (result.IsSuccessful)
            {
                this._currentValue = result.Result;
                this.ControlValueChanged?.Invoke(this, new EventArgs());
                return;
            }

            // If the conversion failed, the text is restored.
            var cursorPosition = this._textBox.SelectionStart;
            this._textBox.Text = this._textConverter.GetText(this._currentValue);
            this._textBox.Select(cursorPosition, 0);
        }
    }
}

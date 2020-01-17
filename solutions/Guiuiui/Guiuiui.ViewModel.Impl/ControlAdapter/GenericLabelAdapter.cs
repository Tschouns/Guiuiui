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
    using Tools.TextConverter;

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericLabelAdapter<TValue> : IControlAdapter<TValue>
    {
        private readonly ITextConverter<TValue> _textConverter;
        private readonly Label _label;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericComboBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericLabelAdapter(
            ITextConverter<TValue> textConverter,
            Label label)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(label, nameof(label));

            this._textConverter = textConverter;
            this._label = label;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.ControlValueChanged"/>. With labels this is never raised.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>.
        /// </summary>
        public TValue Value
        {
            get { return default(TValue); }

            set
            {
                this._label.Text = this._textConverter.GetText(value);
            }
        }
    }
}

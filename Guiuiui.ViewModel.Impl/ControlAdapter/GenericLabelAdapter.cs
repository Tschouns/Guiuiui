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
    /// <typeparam name="TValue">
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </typeparam>
    public class GenericLabelAdapter<TValue> : IControlAdapter<TValue>
    {
        private readonly Label _label;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericComboBoxAdapter{TValue}"/> class.
        /// </summary>
        public GenericLabelAdapter(Label label)
        {
            ArgumentChecks.AssertNotNull(label, nameof(label));

            this._label = label;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>. With labels this is never raised.
        /// </summary>
        public event EventHandler<ControlValueChangedEventArgs<TValue>> ControlValueChanged;

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>.
        /// </summary>
        public TValue Value
        {
            get { return default(TValue); }

            set
            {
                // TODO: create and use a "ITextConverter"
                this._label.Text = value?.ToString();
            }
        }
    }
}

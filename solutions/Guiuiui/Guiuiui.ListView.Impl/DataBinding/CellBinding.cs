//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView.Impl.DataBinding
{
    using Base.RuntimeChecks;
    using Tools.TextConverter;

    /// <summary>
    /// See <see cref="ICellBinding"/>.
    /// </summary>
    /// <typeparam name="TPropertyValue">
    /// Type of the bound property
    /// </typeparam>
    public class CellBinding<TPropertyValue> : ICellBinding
    {
        private readonly ITextConverter<TPropertyValue> _textConverter;
        private readonly IGetter<TPropertyValue> _getter;
        private readonly ICell _cell;

        /// <summary>
        /// Initializes a new instance of the <see cref="CellBinding"/> class.
        /// </summary>
        public CellBinding(
            ITextConverter<TPropertyValue> textConverter,
            IGetter<TPropertyValue> getter,
            ICell cell)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(cell, nameof(cell));

            this._textConverter = textConverter;
            this._getter = getter;
            this._cell = cell;
        }

        /// <summary>
        /// See <see cref="ICellBinding.UpdateCell"/>.
        /// </summary>
        public void UpdateCell()
        {
            var propertyValue = this._getter.Get();
            var propertyText = this._textConverter.GetText(propertyValue);

            this._cell.SetText(propertyText);
        }
    }
}

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

    /// <summary>
    /// See <see cref="IControlAdapter{TValue}"/>.
    /// </summary>
    public class DateTimePickerAdapter : IControlAdapter<DateTime>
    {
        private readonly DateTimePicker _dateTimePicker;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimePickerAdapter"/> class.
        /// </summary>
        public DateTimePickerAdapter(DateTimePicker dateTimePicker)
        {
            ArgumentChecks.AssertNotNull(dateTimePicker, nameof(dateTimePicker));

            this._dateTimePicker = dateTimePicker;
            this._dateTimePicker.ValueChanged += this.DateTimePicker_ValueChanged;
        }

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IControlAdapter{TValue}.Value"/>.
        /// </summary>
        public DateTime Value
        {
            get { return this._dateTimePicker.Value; }
            set
            {
                if (value > this._dateTimePicker.MaxDate)
                {
                    this._dateTimePicker.Value = this._dateTimePicker.MaxDate;
                    return;
                }

                if (value < this._dateTimePicker.MinDate)
                {
                    this._dateTimePicker.Value = this._dateTimePicker.MinDate;
                    return;
                }

                this._dateTimePicker.Value = value;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }
    }
}

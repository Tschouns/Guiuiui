//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.ControlAdapter
{
    using System;
    using Guiuiui.Base.RuntimeChecks;

    /// <summary>
    /// Event arguments of the <see cref="IControlAdapter{TValue}."/>
    /// </summary>
    /// <typeparam name="TValue">
    /// Type of the value represented by the control
    /// </typeparam>
    public class ControlValueChangedEventArgs<TValue> : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlValueChangedEventArgs{TValue}"/> class.
        /// </summary>
        public ControlValueChangedEventArgs(IControlAdapter<TValue> controlAdapter)
        {
            ArgumentChecks.AssertNotNull(controlAdapter, nameof(controlAdapter));

            this.ControlAdapter = controlAdapter;
        }

        /// <summary>
        /// Gets the sender of this event - in a type-safe fashion.
        /// </summary>
        public IControlAdapter<TValue> ControlAdapter { get; }
    }
}

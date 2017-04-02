//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using System;

    /// <summary>
    /// Represents error that occur during data binding setup.
    /// </summary>
    public class DataBindingErrorException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBindingErrorException"/> class.
        /// </summary>
        public DataBindingErrorException(string message)
            : base(message)
        {
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.DataBinding
{
    /// <summary>
    /// Represents a single binding between a property and a control.
    /// </summary>
    public interface IDataBinding
    {
        /// <summary>
        /// Gets a value indicating whether this data binding is active, or already "unbound".
        /// </summary>
        bool IsBound { get; }

        /// <summary>
        /// "Unbinds" the property and control, i.e. makes this data binding ineffective.
        /// </summary>
        void Unbind();
    }
}

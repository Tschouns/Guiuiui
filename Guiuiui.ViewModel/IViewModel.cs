//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel
{
    using Guiuiui.ViewModel.DataBinding;

    /// <summary>
    /// Represents a view model. Contains the actual data model. Allows to set up MVVM-style data binding
    /// for control.
    /// </summary>
    /// <typeparam name="TModel">
    /// Type of the underlying data model
    /// </typeparam>
    public interface IViewModel<TModel>
        where TModel : class
    {
        /// <summary>
        /// Gets the <see cref="IBindable{TModel}"/>, to set up the data binding.
        /// </summary>
        IBindable<TModel> Bind { get; }

        /// <summary>
        /// Gets or sets the actual data model.
        /// </summary>
        TModel Model { get; set; }
    }
}

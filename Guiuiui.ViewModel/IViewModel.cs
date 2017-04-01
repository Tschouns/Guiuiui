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
    /// Whenever a value of <see cref="IViewModel{TModel}.Model"/> is changed by the client code, the view
    /// model must be notified via <see cref="INotifiable.NotifyValueHasChanged"/>.
    /// </summary>
    /// <typeparam name="TModel">
    /// Type of the underlying data model
    /// </typeparam>
    public interface IViewModel<TModel> : INotifyOnValueChanged, INotifiable, IBindable<TModel>
        where TModel : class
    {
        /// <summary>
        /// Gets or sets the actual data model.
        /// </summary>
        TModel Model { get; set; }
    }
}

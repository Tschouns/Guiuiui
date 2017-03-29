//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services
{
    using Guiuiui.ViewModel.DataBinding;

    /// <summary>
    /// See <see cref="IViewModel{TModel}"/>.
    /// </summary>
    /// <typeparam name="TModel">
    /// See <see cref="IViewModel{TModel}"/>.
    /// </typeparam>
    public class ViewModel<TModel> : IViewModel<TModel>
        where TModel : class
    {
        public IBindable<TModel> Bind { get; }
        public TModel Model { get; set; }
    }
}

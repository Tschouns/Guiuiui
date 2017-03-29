//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services
{
    using System;

    /// <summary>
    /// See <see cref="IViewModelFactory"/>.
    /// </summary>
    public class ViewModelFactory : IViewModelFactory
    {
        /// <summary>
        /// See <see cref="IViewModelFactory.CreateViewModel{TModel}"/>.
        /// </summary>
        /// <typeparam name="TModel">
        /// See <see cref="IViewModelFactory.CreateViewModel{TModel}"/>.
        /// </typeparam>
        public IViewModel<TModel> CreateViewModel<TModel>()
            where TModel : class
        {
            return new ViewModel<TModel>();
        }
    }
}

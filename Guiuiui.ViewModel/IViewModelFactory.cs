//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel
{
    /// <summary>
    /// Creates new instances of <see cref="IViewModel{TModel}"/>.
    /// </summary>
    public interface IViewModelFactory
    {
        /// <summary>
        /// Creates a <see cref="IViewModel{TModel}"/>.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        IViewModel<TModel> CreateViewModel<TModel>()
            where TModel : class;
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl
{
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.ViewModel.Impl.ControlAdapter;

    /// <summary>
    /// See <see cref="IViewModelFactory"/>.
    /// </summary>
    public class ViewModelFactory : IViewModelFactory
    {
        private readonly IControlAdapterFactory _controlAdapterFactory;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelFactory"/> class.
        /// </summary>
        public ViewModelFactory(IControlAdapterFactory controlAdapterFactory)
        {
            ArgumentChecks.AssertNotNull(controlAdapterFactory, nameof(controlAdapterFactory));

            this._controlAdapterFactory = controlAdapterFactory;
        }

        /// <summary>
        /// See <see cref="IViewModelFactory.CreateViewModel{TModel}"/>.
        /// </summary>
        /// <typeparam name="TModel">
        /// See <see cref="IViewModelFactory.CreateViewModel{TModel}"/>.
        /// </typeparam>
        public IViewModel<TModel> CreateViewModel<TModel>()
            where TModel : class
        {
            return new ViewModel<TModel>(this._controlAdapterFactory);
        }
    }
}

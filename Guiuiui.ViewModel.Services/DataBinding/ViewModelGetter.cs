//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.DataBinding
{
    using Base.RuntimeChecks;
    using System;

    /// <summary>
    /// See <see cref="IGetter{TPropertyValue}"/>.
    /// </summary>
    public class ViewModelGetter<TModel, TPropertyValue> : IGetter<TPropertyValue>
        where TModel : class
    {
        private readonly IViewModel<TModel> _viewModel;
        private readonly Func<TModel, TPropertyValue> _getFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelGetter{TModel, TPropertyValue}"/> class.
        /// </summary>
        public ViewModelGetter(
            IViewModel<TModel> viewModel,
            Func<TModel, TPropertyValue> getFunc)
        {
            ArgumentChecks.AssertNotNull(viewModel, nameof(viewModel));
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            this._viewModel = viewModel;
            this._getFunc = getFunc;
        }

        /// <summary>
        /// See <see cref="IGetter{TPropertyValue}.Get"/>.
        /// </summary>
        public TPropertyValue Get()
        {
            if (this._viewModel.Model == null)
            {
                return default(TPropertyValue);
            }

            var value = this._getFunc(this._viewModel.Model);

            return value;
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.DataBinding
{
    using Base.RuntimeChecks;
    using System;

    /// <summary>
    /// See <see cref="ISetter{TPropertyValue}"/>.
    /// </summary>
    public class ViewModelSetter<TModel, TPropertyValue> : ISetter<TPropertyValue>
        where TModel : class
    {
        private readonly IViewModel<TModel> _viewModel;
        private readonly Action<TModel, TPropertyValue> _setAction;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelSetter{TModel, TPropertyValue}"/> class.
        /// </summary>
        public ViewModelSetter(
            IViewModel<TModel> viewModel,
            Action<TModel, TPropertyValue> setAction)
        {
            ArgumentChecks.AssertNotNull(viewModel, nameof(viewModel));
            ArgumentChecks.AssertNotNull(setAction, nameof(setAction));

            this._viewModel = viewModel;
            this._setAction = setAction;
        }

        /// <summary>
        /// See <see cref="ISetter{TPropertyValue}.Set(TPropertyValue)"/>.
        /// </summary>
        public void Set(TPropertyValue value)
        {
            if (this._viewModel.Model == null)
            {
                return;
            }

            this._setAction(this._viewModel.Model, value);
            this._viewModel.NotifyValueHasChanged();
        }
    }
}

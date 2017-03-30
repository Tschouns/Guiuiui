//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using System;

    /// <summary>
    /// Provides an interface to bind properties of <typeparamref name="TModel"/> to controls.
    /// </summary>
    /// <typeparam name="TModel">
    /// Type of the underlying data model
    /// </typeparam>
    public interface IBindable<TModel>
        where TModel : class
    {
        /// <summary>
        /// Binds a property read-only.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        IPropertyPredicate BindPropertyGet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc);

        /// <summary>
        /// Binds a property two-way.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        IPropertyPredicate BindPropertyGetAndSet<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TPropertyValue, TModel> SetAction);
    }
}

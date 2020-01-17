//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.TextConverter
{
    using Base.RuntimeChecks;
    using Guiuiui.Tools.TextConverter;
    using System;
    using System.Collections.Concurrent;
    using Tools.Reflection;

    /// <summary>
    /// See <see cref="ITextConverterRegistry"/> and <see cref="ITextConverterProvider"/>.
    /// </summary>
    public class TextConverterRegistry : ITextConverterRegistry, ITextConverterProvider
    {
        private readonly ITypeHelper _typeHelper;
        private readonly ConcurrentDictionary<Type, object> _textConverterDictionary = new ConcurrentDictionary<Type, object>();

        public TextConverterRegistry(ITypeHelper typeHelper)
        {
            ArgumentChecks.AssertNotNull(typeHelper, nameof(typeHelper));

            this._typeHelper = typeHelper;
        }

        /// <summary>
        /// See <see cref="ITextConverterProvider.GetTextConverter{TValue}"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// See <see cref="ITextConverterProvider.GetTextConverter{TValue}"/>.
        /// </typeparam>
        public ITextConverter<TValue> GetTextConverter<TValue>()
        {
            var typePriorities = this._typeHelper.GetInheritedTypes<TValue>();
            foreach(var type in typePriorities)
            {
                object textConverter;
                if (this._textConverterDictionary.TryGetValue(type, out textConverter))
                {
                    return (ITextConverter<TValue>)textConverter;
                }
            }

            return new GenericDefaultTextConverter<TValue>();
        }

        /// <summary>
        /// See <see cref="ITextConverterRegistry.RegisterTextConverter{TValue}(ITextConverter{TValue})"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// See <see cref="ITextConverterRegistry.RegisterTextConverter{TValue}(ITextConverter{TValue})"/>.
        /// </typeparam>
        public void RegisterTextConverter<TValue>(ITextConverter<TValue> textConverter)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));

            this._textConverterDictionary.AddOrUpdate(typeof(TValue), textConverter, (k, v) => textConverter);
        }
    }
}

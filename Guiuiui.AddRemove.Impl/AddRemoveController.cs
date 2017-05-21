//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implements <see cref="IAddRemove"/>. Orchestrates the "add" and "remove" processes.
    /// </summary>
    /// <typeparam name="TItem">
    /// Type of the items in the collection
    /// </typeparam>
    public class AddRemoveController<TItem> : IAddRemove
        where TItem : class
    {
        private readonly Func<ICollection<TItem>> _getItemCollectionFunc;

        /// <summary>
        /// See <see cref="IAddRemove.Add"/>.
        /// </summary>
        public void Add()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IAddRemove.Remove"/>.
        /// </summary>
        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}

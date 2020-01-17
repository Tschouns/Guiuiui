//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove
{
    using System;

    /// <summary>
    /// Allows to initiate "add" and "remove" operations.
    /// </summary>
    public interface IAddRemove
    {
        /// <summary>
        /// Raised whenever the state of the object has changed, and hence the <see cref="IsAddPossible"/>
        /// and <see cref="IsRemovePossible"/> properties may have changed.
        /// </summary>
        event EventHandler StateChanged;

        /// <summary>
        /// Gets a value indicating whether it is currently possible to add an item.
        /// </summary>
        bool IsAddPossible { get; }

        /// <summary>
        /// Gets a value indicating whether it is currently possible to remove an item.
        /// </summary>
        bool IsRemovePossible { get; }

        /// <summary>
        /// Tries to initiate an "add" operation.
        /// </summary>
        /// <returns>
        /// <c>True</c> if something was actually added, otherwise <c>false</c>.
        /// </returns>
        bool TryAdd();

        /// <summary>
        /// Tries to initiate a "remove" operation.
        /// </summary>
        /// <returns>
        /// <c>True</c> if something was actually removed, otherwise <c>false</c>.
        /// </returns>
        bool TryRemove();
    }
}

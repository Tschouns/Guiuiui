//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove
{
    /// <summary>
    /// Allows to initiate "add" and "remove" operations.
    /// </summary>
    public interface IAddRemove
    {
        /// <summary>
        /// Initiates an "add" operation.
        /// </summary>
        void Add();

        /// <summary>
        /// Initiates a "remove" operation.
        /// </summary>
        void Remove();
    }
}

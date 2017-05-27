//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl.ButtonController
{
    using System;
    using System.Windows.Forms;
    using Base.RuntimeChecks;
    using Guiuiui.AddRemove.ButtonController;

    /// <summary>
    /// See <see cref="IButtonController"/>. Locks buttons when performing either operation is not allowed.
    /// </summary>
    public class LockButtonController : IButtonController
    {
        private readonly Button _addButton;
        private readonly Button _removeButton;
        private readonly IAddRemove _addRemoveController;
        private bool _enabled = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="LockButtonController"/> class.
        /// </summary>
        public LockButtonController(
            Button addButton,
            Button removeButton,
            IAddRemove addRemoveController)
        {
            ArgumentChecks.AssertNotNull(addButton, nameof(addButton));
            ArgumentChecks.AssertNotNull(removeButton, nameof(removeButton));
            ArgumentChecks.AssertNotNull(addRemoveController, nameof(addRemoveController));

            this._addButton = addButton;
            this._removeButton = removeButton;
            this._addRemoveController = addRemoveController;

            this.UpdateButtonsStatus();

            this._addButton.Click += this.AddButton_Click;
            this._removeButton.Click += this.RemoveButton_Click;
            this._addRemoveController.StateChanged += this.AddRemoveController_StateChanged;
        }

        /// <summary>
        /// See <see cref="IButtonController.Enabled"/>.
        /// </summary>
        public bool Enabled
        {
            get
            {
                return this._enabled;
            }

            set
            {
                this._enabled = value;
                this.UpdateButtonsStatus();
            }
        }

        private void UpdateButtonsStatus()
        {
            this._addButton.Enabled = this.Enabled && this._addRemoveController.IsAddPossible;
            this._removeButton.Enabled = this.Enabled && this._addRemoveController.IsRemovePossible;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            this._addRemoveController.TryAdd();
        }

        private void RemoveButton_Click(object sender, System.EventArgs e)
        {
            this._addRemoveController.TryRemove();
        }

        private void AddRemoveController_StateChanged(object sender, EventArgs e)
        {
            this.UpdateButtonsStatus();
        }
    }
}

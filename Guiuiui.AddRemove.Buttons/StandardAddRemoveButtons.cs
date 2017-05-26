//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Buttons
{
    using System.Windows.Forms;
    using Base.RuntimeChecks;

    public partial class StandardAddRemoveButtons : UserControl, IAddRemoveButtons
    {
        private IAddRemove _addRemoveController;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardAddRemoveButtons"/> class.
        /// </summary>
        public StandardAddRemoveButtons()
        {
            this.InitializeComponent();

            this.addButton.Text = ButtonCaptions.Add;
            this.removeButton.Text = ButtonCaptions.Remove;
        }

        /// <summary>
        /// See <see cref="IAddRemoveButtons.Initialize(IAddRemove)"/>.
        /// </summary>
        public void Initialize(IAddRemove addRemoveController)
        {
            ArgumentChecks.AssertNotNull(addRemoveController, nameof(addRemoveController));

            this._addRemoveController = addRemoveController;
        }
    }
}

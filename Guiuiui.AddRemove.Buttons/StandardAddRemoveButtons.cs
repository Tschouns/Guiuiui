//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Buttons
{
    using System;
    using System.Windows.Forms;
    using Base.InversionOfControl;
    using Base.RuntimeChecks;
    using ButtonController;

    public partial class StandardAddRemoveButtons : UserControl, IAddRemoveButtons
    {
        private readonly IAddRemoveFactory _addRemoveFactory;
        private IButtonController _buttonController;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardAddRemoveButtons"/> class.
        /// </summary>
        public StandardAddRemoveButtons()
            : this(Ioc.Container.Resolve<IAddRemoveFactory>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardAddRemoveButtons"/> class.
        /// </summary>
        public StandardAddRemoveButtons(
            IAddRemoveFactory addRemoveFactory)
        {
            ArgumentChecks.AssertNotNull(addRemoveFactory, nameof(addRemoveFactory));

            this._addRemoveFactory = addRemoveFactory;

            this.InitializeComponent();

            this._addButton.Text = ButtonCaptions.Add;
            this._removeButton.Text = ButtonCaptions.Remove;
        }

        /// <summary>
        /// See <see cref="IAddRemoveButtons.Initialize(IAddRemove)"/>.
        /// </summary>
        public IButtonController Initialize(IAddRemove addRemoveController)
        {
            ArgumentChecks.AssertNotNull(addRemoveController, nameof(addRemoveController));

            if (this._buttonController != null)
            {
                throw new InvalidOperationException("The buttons have already been initialized.");
            }

            this._buttonController = this._addRemoveFactory.AttachToButtons(
                addRemoveController,
                this._addButton,
                this._removeButton);

            return this._buttonController;
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.DataBinding
{
    using Base.RuntimeChecks;
    using ControlAdapter;
    using System;
    using ViewModel.DataBinding;

    /// <summary>
    /// See <see cref="IDataBinding"/>.
    /// </summary>
    public class ReadOnlyDataBinding<TPropertyValue> : IDataBinding
    {
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<TPropertyValue> _modelPropertyGetter;
        private readonly IControlAdapter<TPropertyValue> _controlAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyDataBinding{TPropertyValue}"/> class.
        /// </summary>
        public ReadOnlyDataBinding(
            INotifyOnValueChanged model,
            IGetter<TPropertyValue> modelPropertyGetter,
            IControlAdapter<TPropertyValue> controlAdapter)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(modelPropertyGetter, nameof(modelPropertyGetter));
            ArgumentChecks.AssertNotNull(controlAdapter, nameof(controlAdapter));

            this._model = model;
            this._modelPropertyGetter = modelPropertyGetter;
            this._controlAdapter = controlAdapter;

            this._model.ValueChanged += this.Model_ValueChanged;
            this._controlAdapter.ControlValueChanged += this.ControlAdapter_ControlValueChanged;

            this.IsBound = true;

            this.InitializeControl();
        }

        /// <summary>
        /// See <see cref="IDataBinding.IsBound"/>.
        /// </summary>
        public bool IsBound { get; private set; }

        /// <summary>
        /// See <see cref="IDataBinding.Unbind"/>.
        /// </summary>
        public void Unbind()
        {
            if (this.IsBound)
            {
                // Stop observing. This will cause this instance to no longer be referenced via the
                // event handlers, and will eventually allow it to be garbage collected.
                this._model.ValueChanged -= this.Model_ValueChanged;
                this._controlAdapter.ControlValueChanged -= this.ControlAdapter_ControlValueChanged;

                this.IsBound = false;
            }
        }

        private void InitializeControl()
        {
            var modelValue = this._modelPropertyGetter.Get();
            this._controlAdapter.Value = modelValue;
        }

        private void ModelToControl()
        {
            var modelValue = this._modelPropertyGetter.Get();
            if (!object.Equals(modelValue, this._controlAdapter.Value))
            {
                this._controlAdapter.Value = modelValue;
            }
        }

        private void Model_ValueChanged(object sender, EventArgs e)
        {
            this.ModelToControl();
        }

        private void ControlAdapter_ControlValueChanged(object sender, ControlValueChangedEventArgs<TPropertyValue> e)
        {
            // Prevent changes being made to the control.
            this.ModelToControl();
        }
    }
}

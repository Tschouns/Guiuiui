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
    public class TwoWayDataBinding<TPropertyValue> : IDataBinding
    {
        private readonly INotifyOnValueChanged _model;
        private readonly IGetter<TPropertyValue> _modelPropertyGetter;
        private readonly ISetter<TPropertyValue> _modelPropertySetter;
        private readonly IControlAdapter<TPropertyValue> _controlAdapter;

        /// <summary>
        /// Used to prevent a stack overflow in case of back coupling due to ill-defined bindings.
        /// </summary>
        private int _callStackDepth = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoWayDataBinding{TPropertyValue}"/> class.
        /// </summary>
        public TwoWayDataBinding(
            INotifyOnValueChanged model,
            IGetter<TPropertyValue> modelPropertyGetter,
            ISetter<TPropertyValue> modelPropertySetter,
            IControlAdapter<TPropertyValue> controlAdapter)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(modelPropertyGetter, nameof(modelPropertyGetter));
            ArgumentChecks.AssertNotNull(modelPropertySetter, nameof(modelPropertySetter));
            ArgumentChecks.AssertNotNull(controlAdapter, nameof(controlAdapter));

            this._model = model;
            this._modelPropertyGetter = modelPropertyGetter;
            this._modelPropertySetter = modelPropertySetter;
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

        private void Model_ValueChanged(object sender, EventArgs e)
        {
            // Prevent stack overflow.
            if (this._callStackDepth > 10)
            {
                return;
            }

            // Model value has changed?
            var modelValue = this._modelPropertyGetter.Get();
            if (!object.Equals(modelValue, this._controlAdapter.Value))
            {
                // Update the control.
                this._callStackDepth++;
                this._controlAdapter.Value = modelValue;
                this._callStackDepth--;
            }
        }

        private void ControlAdapter_ControlValueChanged(object sender, EventArgs e)
        {
            // Prevent stack overflow.
            if (this._callStackDepth > 10)
            {
                return;
            }

            // Control value has changed?
            if (!object.Equals(this._controlAdapter.Value, this._modelPropertyGetter.Get()))
            {
                // Update the model.
                this._callStackDepth++;
                this._modelPropertySetter.Set(this._controlAdapter.Value);
                this._callStackDepth--;
            }
        }
    }
}

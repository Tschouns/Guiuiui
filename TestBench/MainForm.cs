//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace TestBench
{
    using System.Windows.Forms;
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.ViewModel;

    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IViewModelFactory _viewModelFactory;

        public MainForm()
            : this(Ioc.Container.Resolve<IViewModelFactory>())
        {
        }

        public MainForm(IViewModelFactory viewModelFactory)
        {
            ArgumentChecks.AssertNotNull(viewModelFactory, nameof(viewModelFactory));

            this._viewModelFactory = viewModelFactory;

            this.InitializeComponent();
        }
    }
}

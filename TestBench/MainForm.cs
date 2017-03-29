namespace TestBench
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.ViewModel;
    using TestBench.SampleModels;

    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IViewModel<Person> _personViewModel;

        public MainForm()
            : this(Ioc.Container.Resolve<IViewModelFactory>())
        {
        }

        public MainForm(IViewModelFactory viewModelFactory)
        {
            ArgumentChecks.AssertNotNull(viewModelFactory, nameof(viewModelFactory));

            this.InitializeComponent();

            this._personViewModel = viewModelFactory.CreateViewModel<Person>();
            this.InitializePersonListView();
        }

        private static TModel GetSelectedModel<TModel>(ListView listView)
        {
            var selectedModel = listView.SelectedItems
                .Cast<ListViewItem>()
                .Select(i => i.Tag)
                .Cast<TModel>()
                .FirstOrDefault();

            return selectedModel;
        }

        private void InitializePersonListView()
        {
            var fritzMeier = new Person()
            {
                Name = "Meier",
                FirstName = "Fritz",
                Gender = Gender.Male
            };

            var hugoHugentobler = new Person()
            {
                Name = "Hugentobler",
                FirstName = "Hugo",
                Gender = Gender.Male
            };

            var hubertStaffelbach = new Person()
            {
                Name = "Staffelbach",
                FirstName = "Hubert",
                Gender = Gender.Male
            };

            var gunhildeStaffelbach = new Person()
            {
                Name = "Staffelbach",
                FirstName = "Gunhilde",
                Gender = Gender.Female
            };

            var persons = new Person[]
            {
                fritzMeier,
                hugoHugentobler,
                hubertStaffelbach,
                gunhildeStaffelbach
            };

            foreach (var person in persons)
            {
                this.personListView.Items.Add(new ListViewItem(person.FirstName + " " + person.Name)
                {
                    Tag = person
                });
            }
        }


        private void personListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this._personViewModel.Model = GetSelectedModel<Person>(this.personListView);
        }
    }
}

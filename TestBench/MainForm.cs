namespace TestBench
{
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
            this.SetupDataBinding();
            this.FillComboBoxes();
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

        private void SetupDataBinding()
        {
            this._personViewModel.BindPropertyGetAndSet(p => p.FirstName, (p, v) => p.FirstName = v).ToTextBox(this.firstNameTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.Name, (p, v) => p.Name = v).ToTextBox(this.nameTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.Age, (p, v) => p.Age = v).ToTextBox(this.ageTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.Gender, (p, v) => p.Gender = v).ToComboBox(this.genderComboBox);
        }

        private void FillComboBoxes()
        {
            this.genderComboBox.Items.Add(Gender.Male);
            this.genderComboBox.Items.Add(Gender.Female);
        }

        private void InitializePersonListView()
        {
            var fritzMeier = new Person()
            {
                Name = "Meier",
                FirstName = "Fritz",
                Age = 34,
                Gender = Gender.Male
            };

            var hugoHugentobler = new Person()
            {
                Name = "Hugentobler",
                FirstName = "Hugo",
                Age = 77,
                Gender = Gender.Male
            };

            var hubertStaffelbach = new Person()
            {
                Name = "Staffelbach",
                FirstName = "Hubert",
                Age = 50,
                Gender = Gender.Male
            };

            var gunhildeStaffelbach = new Person()
            {
                Name = "Staffelbach",
                FirstName = "Gunhilde",
                Age = 51,
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

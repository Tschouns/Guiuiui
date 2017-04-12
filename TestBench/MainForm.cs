namespace TestBench
{
    using System.Windows.Forms;
    using System.Linq;
    using Guiuiui.ViewModel;
    using TestBench.SampleModels;
    using Guiuiui.Tools;
    using SampleTextConverters;
    using Guiuiui.ListView;

    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IListView<Person> _personListView;
        private readonly IViewModel<Person> _personViewModel;

        private readonly IListView<Address> _addressListViewWrapper;

        public MainForm()
        {
            this.InitializeComponent();

            BaseToolBox.TextConverterRegistry.RegisterTextConverter(new GenderTextConverter());

            this._personListView = ListViewToolBox.ListViewFactory.CreateListView<Person>(this.personListView);
            this._personViewModel = ViewModelToolBox.ViewModelFactory.CreateViewModel<Person>();
            this._addressListViewWrapper = ListViewToolBox.ListViewFactory.CreateListView<Address>(this.addressListView);

            this.SetupDataBinding();
            this.FillComboBoxes();
            this.InitializePersonListView();
        }

        private void SetupDataBinding()
        {
            // "Persons" list view
            this._personListView
                .AddColumnBindingForProperty(p => p.FirstName)
                .AddColumnBindingForProperty(p => p.LastName);

            this._personListView.AddViewModelForSelectedItem(this._personViewModel);

            // "Person" view model
            this._personViewModel.BindPropertyGet(p => p.Summary).ToLabel(this.summaryLabel);

            this._personViewModel.BindPropertyGetAndSet(p => p.FirstName, (p, v) => p.FirstName = v).ToTextBox(this.firstNameTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.LastName, (p, v) => p.LastName = v).ToTextBox(this.nameTextBox);
            this._personViewModel.BindPropertyGet(p => p.FullName).ToTextBox(this.fullNameTextBox);

            this._personViewModel.BindPropertyGetAndSet(p => p.Age, (p, v) => p.Age = v).ToTextBox(this.ageTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.Gender, (p, v) => p.Gender = v).ToComboBox(this.genderComboBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.IsVegetarian, (p, v) => p.IsVegetarian = v).ToCheckBox(this.isVegetarianCheckBox);

            this._personViewModel.BindListProperty(p => p.Addresses).ToListControl(this._addressListViewWrapper);

            // "Addresses" list view
            this._addressListViewWrapper
                .AddColumnBindingForProperty(i => i.Street)
                .AddColumnBindingForProperty(i => i.PostalCode)
                .AddColumnBindingForProperty(i => i.City);
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
                LastName = "Meier",
                FirstName = "Fritz",
                Age = 34,
                Gender = Gender.Male,
                IsVegetarian = true
            };

            var hugoHugentobler = new Person()
            {
                LastName = "Hugentobler",
                FirstName = "Hugo",
                Age = 77,
                Gender = Gender.Undefined
            };

            hugoHugentobler.Addresses.Add(new Address
            {
                Street = "Tobelstrasse 15",
                PostalCode = 1234,
                City = "Staffelshausen"
            });

            var hubertStaffelbach = new Person()
            {
                LastName = "Staffelbach",
                FirstName = "Hubert",
                Age = 50,
                Gender = Gender.Male
            };

            hubertStaffelbach.Addresses.Add(new Address
            {
                Street = "Staffelweg 12",
                PostalCode = 1234,
                City = "Staffelshausen"
            });

            hubertStaffelbach.Addresses.Add(new Address
            {
                Street = "Blechheimstrasse 76",
                PostalCode = 5432,
                City = "Brunzilausi"
            });

            var gunhildeStaffelbach = new Person()
            {
                LastName = "Staffelbach",
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

            this._personListView.SetListItemsToDisplay(persons);
        }
    }
}

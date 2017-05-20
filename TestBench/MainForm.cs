namespace TestBench
{
    using System;
    using System.Windows.Forms;
    using Guiuiui.ViewModel;
    using TestBench.SampleModels;
    using Guiuiui.Tools;
    using SampleTextConverters;
    using Guiuiui.ListView;
    using Guiuiui.Facade;

    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IListView<Person> _personListViewWrapper;
        private readonly IViewModel<Person> _personViewModel;

        private readonly IListView<Address> _addressListViewWrapper;
        private readonly IViewModel<Address> _addressViewModel1;
        private readonly IViewModel<Address> _addressViewModel2;

        public MainForm()
        {
            this.InitializeComponent();

            ToolBox.TextConverterRegistry.RegisterTextConverter(new GenderTextConverter());
            ToolBox.TextConverterRegistry.RegisterTextConverter(new AddressTextConverter());

            this._personListViewWrapper = ToolBox.ListViewFactory.CreateListView<Person>(this.personListView);
            this._personViewModel = ToolBox.ViewModelFactory.CreateViewModel<Person>();
            this._addressListViewWrapper = ToolBox.ListViewFactory.CreateListView<Address>(this.addressListView);
            this._addressViewModel1 = ToolBox.ViewModelFactory.CreateViewModel<Address>();
            this._addressViewModel2 = ToolBox.ViewModelFactory.CreateViewModel<Address>();

            this.SetupDataBinding();
            this.FillComboBoxes();
            this.InitializePersonListView();
        }

        private void SetupDataBinding()
        {
            // "Persons" list view
            this._personListViewWrapper
                .AddColumnBindingForProperty(p => p.FirstName)
                .AddColumnBindingForProperty(p => p.LastName);

            this._personListViewWrapper.AddViewModelForSelectedItem(this._personViewModel);

            // "Person" view model
            this._personViewModel.BindPropertyGet(p => p.Summary).ToLabel(this.summaryLabel);

            this._personViewModel.BindPropertyGetAndSet(p => p.FirstName, (p, v) => p.FirstName = v).ToTextBox(this.firstNameTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.LastName, (p, v) => p.LastName = v).ToTextBox(this.nameTextBox);
            this._personViewModel.BindPropertyGet(p => p.FullName).ToTextBox(this.fullNameTextBox);
            
            this._personViewModel.BindPropertyGetAndSet(p => p.DateOfBirth, (p, v) => p.DateOfBirth = v).ToDateTimePicker(this.dateOfBirthDateTimePicker);
            this._personViewModel.BindPropertyGetAndSet(p => p.Gender, (p, v) => p.Gender = v).ToComboBox(this.genderComboBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.IsVegetarian, (p, v) => p.IsVegetarian = v).ToCheckBox(this.isVegetarianCheckBox);

            this._personViewModel.BindListProperty(p => p.Addresses).ToListControl(this._addressListViewWrapper);

            // "Addresses" list view
            this._addressListViewWrapper.AddViewModelForSelectedItem(this._addressViewModel1);
            this._addressListViewWrapper.AddViewModelForSelectedItem(this._addressViewModel2);

            // "Address 1" view model
            this._addressViewModel1.BindPropertyGetAndSet(a => a.Street, (a, v) => a.Street = v).ToTextBox(this.streetTextBox1);
            this._addressViewModel1.BindPropertyGetAndSet(a => a.PostalCode, (a, v) => a.PostalCode = v).ToTextBox(this.postalCodeTextBox1);
            this._addressViewModel1.BindPropertyGetAndSet(a => a.City, (a, v) => a.City = v).ToTextBox(this.cityTextBox1);

            // "Address 2" view model
            this._addressViewModel2.BindPropertyGetAndSet(a => a.Street, (a, v) => a.Street = v).ToTextBox(this.streetTextBox2);
            this._addressViewModel2.BindPropertyGetAndSet(a => a.PostalCode, (a, v) => a.PostalCode = v).ToTextBox(this.postalCodeTextBox2);
            this._addressViewModel2.BindPropertyGetAndSet(a => a.City, (a, v) => a.City = v).ToTextBox(this.cityTextBox2);
        }

        private void FillComboBoxes()
        {
            this.genderComboBox.Items.Add(Gender.Male);
            this.genderComboBox.Items.Add(Gender.Female);
        }

        private void InitializePersonListView()
        {
            var fritzMeier = new Person
            {
                LastName = "Meier",
                FirstName = "Fritz",
                DateOfBirth = new DateTime(1983, 4, 18),
                Gender = Gender.Male,
                IsVegetarian = true
            };

            var hugoHugentobler = new Person
            {
                LastName = "Hugentobler",
                FirstName = "Hugo",
                DateOfBirth = new DateTime(1971, 11, 2),
                Gender = Gender.Undefined
            };

            hugoHugentobler.Addresses.Add(new Address
            {
                Street = "Tobelstrasse 15",
                PostalCode = 1234,
                City = "Staffelshausen"
            });

            var hubertStaffelbach = new Person
            {
                LastName = "Staffelbach",
                FirstName = "Hubert",
                DateOfBirth = new DateTime(1955, 8, 30),
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

            hubertStaffelbach.Addresses.Add(new Address
            {
                Street = "Holzweg 4",
                PostalCode = 8866,
                City = "Knittlingen"
            });

            var gunhildeStaffelbach = new Person
            {
                LastName = "Staffelbach",
                FirstName = "Gunhilde",
                DateOfBirth = new DateTime(1966, 3, 3),
                Gender = Gender.Female
            };

            var persons = new Person[]
            {
                fritzMeier,
                hugoHugentobler,
                hubertStaffelbach,
                gunhildeStaffelbach
            };

            this._personListViewWrapper.SetListItemsToDisplay(persons);
        }
    }
}

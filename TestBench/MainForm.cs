namespace TestBench
{
    using System;
    using System.Windows.Forms;
    using Guiuiui.ViewModel;
    using TestBench.SampleModels;
    using SampleTextConverters;
    using Guiuiui.ListView;
    using Guiuiui.Facade;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        // Person
        private readonly IListView<Person> _personListViewWrapper;
        private readonly IViewModel<Person> _personViewModel;

        // Address
        private readonly IListView<Address> _addressListViewWrapper;
        private readonly IViewModel<Address> _addressViewModel1;
        private readonly IViewModel<Address> _addressViewModel2;

        // Mock data
        private readonly IList<Person> _persons;

        public MainForm()
        {
            this.InitializeComponent();

            GuiuiuiToolBox.TextConverterRegistry.RegisterTextConverter(new GenderTextConverter());
            GuiuiuiToolBox.TextConverterRegistry.RegisterTextConverter(new AddressTextConverter());

            this._personListViewWrapper = GuiuiuiToolBox.ListViewFactory.Create<Person>(this.personListView);
            this._personViewModel = GuiuiuiToolBox.ViewModelFactory.Create<Person>();
            this._addressListViewWrapper = GuiuiuiToolBox.ListViewFactory.Create<Address>(this.addressListView);
            this._addressViewModel1 = GuiuiuiToolBox.ViewModelFactory.Create<Address>();
            this._addressViewModel2 = GuiuiuiToolBox.ViewModelFactory.Create<Address>();

            this.SetupDataBinding();
            this.SetupAddRemoveControllers();
            this.FillComboBoxes();

            this._persons = this.CreatePersons();

            this._personListViewWrapper.SetListItemsToDisplay(this._persons);
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

        private void SetupAddRemoveControllers()
        {
            // "Persons"
            var personAddRemoveController = GuiuiuiToolBox.AddRemoveFactory.CreateAddRemoveController(
                () => this._persons,
                this._personListViewWrapper);

            this.personAddRemoveButtons.Initialize(personAddRemoveController);

            // "Addresses"
            var addressAddRemoveController = GuiuiuiToolBox.AddRemoveFactory.CreateAddRemoveController(
                this._personViewModel,
                p => p.Addresses,
                this._addressListViewWrapper);

            this.addressAddRemoveButtons.Initialize(addressAddRemoveController);
        }

        private void FillComboBoxes()
        {
            this.genderComboBox.Items.Add(Gender.Male);
            this.genderComboBox.Items.Add(Gender.Female);
        }

        /// <summary>
        /// Just creates some dummy data for demonstration purposes.
        /// </summary>
        private IList<Person> CreatePersons()
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

            return persons.ToList();
        }
    }
}

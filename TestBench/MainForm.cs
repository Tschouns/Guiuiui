namespace TestBench
{
    using System.Windows.Forms;
    using System.Linq;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.ViewModel;
    using TestBench.SampleModels;
    using Guiuiui.Tools;
    using SampleTextConverters;

    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IViewModel<Person> _personViewModel;

        public MainForm()
        {
            this.InitializeComponent();

            BaseToolBox.TextConverterRegistry.RegisterTextConverter(new GenderTextConverter());

            this._personViewModel = ViewModelToolBox.ViewModelFactory.CreateViewModel<Person>();

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
            this._personViewModel.BindPropertyGetAndSet(p => p.LastName, (p, v) => p.LastName = v).ToTextBox(this.nameTextBox);
            this._personViewModel.BindPropertyGet(p => p.FullName).ToTextBox(this.fullNameTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.Age, (p, v) => p.Age = v).ToTextBox(this.ageTextBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.Gender, (p, v) => p.Gender = v).ToComboBox(this.genderComboBox);
            this._personViewModel.BindPropertyGetAndSet(p => p.IsVegetarian, (p, v) => p.IsVegetarian = v).ToCheckBox(this.isVegetarianCheckBox);
            this._personViewModel.BindPropertyGet(p => p.Summary).ToLabel(this.summaryLabel);
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

            var hubertStaffelbach = new Person()
            {
                LastName = "Staffelbach",
                FirstName = "Hubert",
                Age = 50,
                Gender = Gender.Male
            };

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

            foreach (var person in persons)
            {
                var item = new ListViewItem()
                {
                    //Text = person.FirstName + " " + person.LastName,
                    Tag = person
                };

                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, person.FirstName));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, person.LastName));

                this.personListView.Items.Add(item);
            }
        }

        private void personListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this._personViewModel.Model = GetSelectedModel<Person>(this.personListView);
        }
    }
}

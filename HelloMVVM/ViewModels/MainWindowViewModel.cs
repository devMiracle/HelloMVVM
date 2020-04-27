namespace HelloMVVM.ViewModels
{
    using Catel.Data;
    using Catel.MVVM;
    using System.Threading.Tasks;
    using System.Windows;

    public class MainWindowViewModel : ViewModelBase
    {
        public static readonly PropertyData FirstNameProperty;
        public Command ShowFirstName { get; private set; }
        static MainWindowViewModel()
        {
            FirstNameProperty
                = RegisterProperty(nameof(FirstName), typeof(string), null);
        }

        public MainWindowViewModel()
        {
            ShowFirstName = new Command(OnShowFirstNameExecute, OnShowFirstNameCanExecute);
        }

        public override string Title { get { return "Welcome to HelloMVVM"; } }

        public string FirstName
        {
            get { return GetValue<string>(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        private void OnShowFirstNameExecute()
        {
            MessageBox.Show(FirstName);
        }

        private bool OnShowFirstNameCanExecute()
        {
            return true;
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}

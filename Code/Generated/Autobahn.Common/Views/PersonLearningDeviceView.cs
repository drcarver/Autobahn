//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLearningDeviceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonLearningDeviceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonLearningDeviceView : ContentPage
    {
        /// <summary>
        /// Inject the PersonLearningDeviceViewModel as the data context for the view
        /// </summary>
        public PersonLearningDeviceView(PersonLearningDeviceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

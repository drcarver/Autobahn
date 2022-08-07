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
        /// Inject the IPersonLearningDeviceViewModel as the data context for the view
        /// </summary>
        public PersonLearningDeviceView(IPersonLearningDeviceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

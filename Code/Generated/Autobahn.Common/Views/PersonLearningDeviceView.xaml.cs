//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonLearningDeviceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonLearningDeviceView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonLearningDevice View Model as the data context for the view
        /// </summary>
        public PersonLearningDeviceView(Interfaces.IPersonLearningDevice vm)
        {
            BindingContext  = vm;
        }
    }
}

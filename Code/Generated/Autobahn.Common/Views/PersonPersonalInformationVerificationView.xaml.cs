//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonPersonalInformationVerificationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonPersonalInformationVerificationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPersonalInformationVerificationView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonPersonalInformationVerificationViewModel as the data context for the view
        /// </summary>
        public PersonPersonalInformationVerificationView(IPersonPersonalInformationVerificationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

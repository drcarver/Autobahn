//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonPersonalInformationVerificationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPersonalInformationVerificationView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonPersonalInformationVerification View Model as the data context for the view
        /// </summary>
        public PersonPersonalInformationVerificationView(Interfaces.IPersonPersonalInformationVerification vm)
        {
            BindingContext  = vm;
        }
    }
}

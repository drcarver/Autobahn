//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonReferralView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonReferralView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonReferral View Model as the data context for the view
        /// </summary>
        public PersonReferralView(Interfaces.IPersonReferral vm)
        {
            BindingContext  = vm;
        }
    }
}

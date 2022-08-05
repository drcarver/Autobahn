//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonReferralView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonReferralView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonReferralView : ContentPage
    {
        /// <summary>
        /// Inject the PersonReferralViewModel as the data context for the view
        /// </summary>
        public PersonReferralView(PersonReferralViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

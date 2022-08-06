//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDegreeOrCertificateView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDegreeOrCertificateView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDegreeOrCertificateView : ContentPage
    {
        /// <summary>
        /// Inject the PersonDegreeOrCertificateViewModel as the data context for the view
        /// </summary>
        public PersonDegreeOrCertificateView(PersonDegreeOrCertificateViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

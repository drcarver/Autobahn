//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDegreeOrCertificateView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDegreeOrCertificateView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDegreeOrCertificate View Model as the data context for the view
        /// </summary>
        public PersonDegreeOrCertificateView(Interfaces.IPersonDegreeOrCertificate vm)
        {
            BindingContext  = vm;
        }
    }
}

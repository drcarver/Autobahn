//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolAuthorizerAgencyView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgencyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CharterSchoolAuthorizerAgencyView : ContentPage
    {
        /// <summary>
        /// Inject the IK12CharterSchoolAuthorizerAgency View Model as the data context for the view
        /// </summary>
        public K12CharterSchoolAuthorizerAgencyView(Interfaces.IK12CharterSchoolAuthorizerAgency vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolAuthorizerAgencyView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgencyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CharterSchoolAuthorizerAgencyView : ContentPage
    {
        /// <summary>
        /// Inject the K12CharterSchoolAuthorizerAgencyViewModel as the data context for the view
        /// </summary>
        public K12CharterSchoolAuthorizerAgencyView(K12CharterSchoolAuthorizerAgencyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

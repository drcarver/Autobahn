//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentDemographicView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentDemographicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentDemographicView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentDemographicViewModel as the data context for the view
        /// </summary>
        public PsStudentDemographicView(IPsStudentDemographicViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

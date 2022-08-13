//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentDemographicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentDemographicView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentDemographic View Model as the data context for the view
        /// </summary>
        public PsStudentDemographicView(Interfaces.IPsStudentDemographic vm)
        {
            BindingContext  = vm;
        }
    }
}

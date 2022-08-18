//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LEATitleIIIProfessionalDevelopmentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LEATitleIIIProfessionalDevelopmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LEATitleIIIProfessionalDevelopmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LEATitleIIIProfessionalDevelopment View Model as the data context for the view
        /// </summary>
        public K12LEATitleIIIProfessionalDevelopmentView(Interfaces.IK12LEATitleIIIProfessionalDevelopment vm)
        {
            BindingContext  = vm;
        }
    }
}

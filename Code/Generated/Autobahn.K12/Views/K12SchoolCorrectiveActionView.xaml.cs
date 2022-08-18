//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolCorrectiveActionView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolCorrectiveActionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolCorrectiveActionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolCorrectiveAction View Model as the data context for the view
        /// </summary>
        public K12SchoolCorrectiveActionView(Interfaces.IK12SchoolCorrectiveAction vm)
        {
            BindingContext  = vm;
        }
    }
}

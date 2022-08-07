//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolCorrectiveActionView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolCorrectiveActionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolCorrectiveActionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolCorrectiveActionViewModel as the data context for the view
        /// </summary>
        public K12SchoolCorrectiveActionView(IK12SchoolCorrectiveActionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

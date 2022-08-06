//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaGradeLevelsApprovedView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaGradeLevelsApprovedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaGradeLevelsApprovedView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaGradeLevelsApprovedViewModel as the data context for the view
        /// </summary>
        public K12LeaGradeLevelsApprovedView(K12LeaGradeLevelsApprovedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

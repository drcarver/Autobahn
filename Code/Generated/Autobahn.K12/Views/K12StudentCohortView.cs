//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCohortView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentCohortView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentCohortView : ContentPage
    {
        /// <summary>
        /// Inject the K12StudentCohortViewModel as the data context for the view
        /// </summary>
        public K12StudentCohortView(K12StudentCohortViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

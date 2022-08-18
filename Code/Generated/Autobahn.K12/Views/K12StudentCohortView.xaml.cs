//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentCohortView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentCohortView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentCohort View Model as the data context for the view
        /// </summary>
        public K12StudentCohortView(Interfaces.IK12StudentCohort vm)
        {
            BindingContext  = vm;
        }
    }
}

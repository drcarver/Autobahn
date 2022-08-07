//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentEnrollmentView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentEnrollmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentEnrollmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentEnrollmentViewModel as the data context for the view
        /// </summary>
        public K12StudentEnrollmentView(IK12StudentEnrollmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

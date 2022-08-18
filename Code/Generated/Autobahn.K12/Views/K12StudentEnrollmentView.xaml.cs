//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentEnrollmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentEnrollmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentEnrollment View Model as the data context for the view
        /// </summary>
        public K12StudentEnrollmentView(Interfaces.IK12StudentEnrollment vm)
        {
            BindingContext  = vm;
        }
    }
}

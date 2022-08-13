//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentAcademicHonorView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentAcademicHonorView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentAcademicHonor View Model as the data context for the view
        /// </summary>
        public K12StudentAcademicHonorView(Interfaces.IK12StudentAcademicHonor vm)
        {
            BindingContext  = vm;
        }
    }
}

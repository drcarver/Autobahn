//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicHonorView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentAcademicHonorView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentAcademicHonorView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentAcademicHonorViewModel as the data context for the view
        /// </summary>
        public K12StudentAcademicHonorView(IK12StudentAcademicHonorViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

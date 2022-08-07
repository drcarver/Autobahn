//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentGraduationPlanView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentGraduationPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentGraduationPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentGraduationPlanViewModel as the data context for the view
        /// </summary>
        public K12StudentGraduationPlanView(IK12StudentGraduationPlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

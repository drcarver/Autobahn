//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentGraduationPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentGraduationPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentGraduationPlan View Model as the data context for the view
        /// </summary>
        public K12StudentGraduationPlanView(Interfaces.IK12StudentGraduationPlan vm)
        {
            BindingContext  = vm;
        }
    }
}

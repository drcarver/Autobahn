//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentDisciplineView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentDisciplineView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentDiscipline View Model as the data context for the view
        /// </summary>
        public K12StudentDisciplineView(Interfaces.IK12StudentDiscipline vm)
        {
            BindingContext  = vm;
        }
    }
}

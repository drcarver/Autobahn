//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentDisciplineView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentDisciplineView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentDisciplineView : ContentPage
    {
        /// <summary>
        /// Inject the K12StudentDisciplineViewModel as the data context for the view
        /// </summary>
        public K12StudentDisciplineView(K12StudentDisciplineViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

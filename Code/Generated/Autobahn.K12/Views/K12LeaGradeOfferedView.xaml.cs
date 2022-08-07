//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaGradeOfferedView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaGradeOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaGradeOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaGradeOfferedViewModel as the data context for the view
        /// </summary>
        public K12LeaGradeOfferedView(IK12LeaGradeOfferedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolGradeOfferedView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolGradeOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolGradeOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the K12SchoolGradeOfferedViewModel as the data context for the view
        /// </summary>
        public K12SchoolGradeOfferedView(K12SchoolGradeOfferedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

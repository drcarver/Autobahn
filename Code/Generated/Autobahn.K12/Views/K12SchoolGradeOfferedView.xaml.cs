//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeOfferedView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolGradeOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolGradeOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolGradeOffered View Model as the data context for the view
        /// </summary>
        public K12SchoolGradeOfferedView(Interfaces.IK12SchoolGradeOffered vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaGradeOfferedView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaGradeOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaGradeOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaGradeOffered View Model as the data context for the view
        /// </summary>
        public K12LeaGradeOfferedView(Interfaces.IK12LeaGradeOffered vm)
        {
            BindingContext  = vm;
        }
    }
}

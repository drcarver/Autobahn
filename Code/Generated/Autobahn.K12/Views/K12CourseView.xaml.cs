//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CourseView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CourseView : ContentPage
    {
        /// <summary>
        /// Inject the IK12Course View Model as the data context for the view
        /// </summary>
        public K12CourseView(Interfaces.IK12Course vm)
        {
            BindingContext  = vm;
        }
    }
}

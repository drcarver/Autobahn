//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CourseView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CourseView : ContentPage
    {
        /// <summary>
        /// Inject the IK12CourseViewModel as the data context for the view
        /// </summary>
        public K12CourseView(IK12CourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   CteCourseView.cs
//**********************************************************

using Autobahn.CareerandTechnical.ViewModels;

namespace Autobahn.CareerandTechnical.Views
{
     /// <summary>
     /// The CteCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CteCourseView : ContentPage
    {
        /// <summary>
        /// Inject the ICteCourseViewModel as the data context for the view
        /// </summary>
        public CteCourseView(ICteCourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

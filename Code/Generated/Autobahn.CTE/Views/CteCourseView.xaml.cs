//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteCourseView.cs
//**********************************************************

namespace Autobahn.CTE.Views
{
     /// <summary>
     /// The CteCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CteCourseView : ContentPage
    {
        /// <summary>
        /// Inject the ICteCourse View Model as the data context for the view
        /// </summary>
        public CteCourseView(Interfaces.ICteCourse vm)
        {
            BindingContext  = vm;
        }
    }
}

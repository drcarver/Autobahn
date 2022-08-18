//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsCourseView : ContentPage
    {
        /// <summary>
        /// Inject the IPsCourse View Model as the data context for the view
        /// </summary>
        public PsCourseView(Interfaces.IPsCourse vm)
        {
            BindingContext  = vm;
        }
    }
}

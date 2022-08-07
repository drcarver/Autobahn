//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsCourseView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsCourseView : ContentPage
    {
        /// <summary>
        /// Inject the IPsCourseViewModel as the data context for the view
        /// </summary>
        public PsCourseView(IPsCourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

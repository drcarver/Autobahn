//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentApplicationView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentApplicationViewModel as the data context for the view
        /// </summary>
        public PsStudentApplicationView(PsStudentApplicationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

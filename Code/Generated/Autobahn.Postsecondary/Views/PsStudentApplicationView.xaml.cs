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
        /// Inject the IPsStudentApplicationViewModel as the data context for the view
        /// </summary>
        public PsStudentApplicationView(IPsStudentApplicationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

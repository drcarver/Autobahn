//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentApplication View Model as the data context for the view
        /// </summary>
        public PsStudentApplicationView(Interfaces.IPsStudentApplication vm)
        {
            BindingContext  = vm;
        }
    }
}

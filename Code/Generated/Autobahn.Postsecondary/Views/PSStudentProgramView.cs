//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PSStudentProgramView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PSStudentProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PSStudentProgramView : ContentPage
    {
        /// <summary>
        /// Inject the PSStudentProgramViewModel as the data context for the view
        /// </summary>
        public PSStudentProgramView(PSStudentProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

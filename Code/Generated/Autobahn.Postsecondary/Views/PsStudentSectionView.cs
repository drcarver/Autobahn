//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentSectionView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentSectionView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentSectionViewModel as the data context for the view
        /// </summary>
        public PsStudentSectionView(PsStudentSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

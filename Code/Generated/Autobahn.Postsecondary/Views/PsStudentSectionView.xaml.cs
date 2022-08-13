//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentSection View Model as the data context for the view
        /// </summary>
        public PsStudentSectionView(Interfaces.IPsStudentSection vm)
        {
            BindingContext  = vm;
        }
    }
}

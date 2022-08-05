//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffEmploymentView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the K12StaffEmploymentViewModel as the data context for the view
        /// </summary>
        public K12StaffEmploymentView(K12StaffEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

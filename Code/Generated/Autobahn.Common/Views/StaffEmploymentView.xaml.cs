//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEmploymentView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the StaffEmploymentViewModel as the data context for the view
        /// </summary>
        public StaffEmploymentView(StaffEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

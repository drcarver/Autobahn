//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffProfessionalDevelopmentActivityView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffProfessionalDevelopmentActivityView : ContentPage
    {
        /// <summary>
        /// Inject the StaffProfessionalDevelopmentActivityViewModel as the data context for the view
        /// </summary>
        public StaffProfessionalDevelopmentActivityView(StaffProfessionalDevelopmentActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
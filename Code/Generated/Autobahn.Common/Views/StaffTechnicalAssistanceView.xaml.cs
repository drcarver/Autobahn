//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffTechnicalAssistanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffTechnicalAssistanceView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffTechnicalAssistance View Model as the data context for the view
        /// </summary>
        public StaffTechnicalAssistanceView(Interfaces.IStaffTechnicalAssistance vm)
        {
            BindingContext  = vm;
        }
    }
}

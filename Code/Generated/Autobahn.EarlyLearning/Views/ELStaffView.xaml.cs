//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffView : ContentPage
    {
        /// <summary>
        /// Inject the IELStaff View Model as the data context for the view
        /// </summary>
        public ELStaffView(Interfaces.IELStaff vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StaffEmployment View Model as the data context for the view
        /// </summary>
        public K12StaffEmploymentView(Interfaces.IK12StaffEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}

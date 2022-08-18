//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolApprovalAgencyView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CharterSchoolApprovalAgencyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CharterSchoolApprovalAgencyView : ContentPage
    {
        /// <summary>
        /// Inject the IK12CharterSchoolApprovalAgency View Model as the data context for the view
        /// </summary>
        public K12CharterSchoolApprovalAgencyView(Interfaces.IK12CharterSchoolApprovalAgency vm)
        {
            BindingContext  = vm;
        }
    }
}

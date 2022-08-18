//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12OrganizationStudentResponsibilityView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12OrganizationStudentResponsibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12OrganizationStudentResponsibilityView : ContentPage
    {
        /// <summary>
        /// Inject the IK12OrganizationStudentResponsibility View Model as the data context for the view
        /// </summary>
        public K12OrganizationStudentResponsibilityView(Interfaces.IK12OrganizationStudentResponsibility vm)
        {
            BindingContext  = vm;
        }
    }
}

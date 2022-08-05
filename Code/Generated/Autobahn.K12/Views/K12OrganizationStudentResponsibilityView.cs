//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12OrganizationStudentResponsibilityView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12OrganizationStudentResponsibilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12OrganizationStudentResponsibilityView : ContentPage
    {
        /// <summary>
        /// Inject the K12OrganizationStudentResponsibilityViewModel as the data context for the view
        /// </summary>
        public K12OrganizationStudentResponsibilityView(K12OrganizationStudentResponsibilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

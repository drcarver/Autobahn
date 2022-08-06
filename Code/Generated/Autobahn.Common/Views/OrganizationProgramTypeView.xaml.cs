//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationProgramTypeView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationProgramTypeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationProgramTypeView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationProgramTypeViewModel as the data context for the view
        /// </summary>
        public OrganizationProgramTypeView(OrganizationProgramTypeViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

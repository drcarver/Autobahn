//**********************************************************
//* DomainName: Common Models
//* FileName:   Parent_OrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The Parent_OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Parent_OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IParent_Organization View Model as the data context for the view
        /// </summary>
        public Parent_OrganizationView(Interfaces.IParent_Organization vm)
        {
            BindingContext  = vm;
        }
    }
}

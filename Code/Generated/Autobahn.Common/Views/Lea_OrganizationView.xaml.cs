//**********************************************************
//* DomainName: Common Models
//* FileName:   Lea_OrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The Lea_OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lea_OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the ILea_Organization View Model as the data context for the view
        /// </summary>
        public Lea_OrganizationView(Interfaces.ILea_Organization vm)
        {
            BindingContext  = vm;
        }
    }
}

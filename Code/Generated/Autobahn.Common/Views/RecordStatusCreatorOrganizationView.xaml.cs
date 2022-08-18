//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusCreatorOrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RecordStatusCreatorOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordStatusCreatorOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IRecordStatusCreatorOrganization View Model as the data context for the view
        /// </summary>
        public RecordStatusCreatorOrganizationView(Interfaces.IRecordStatusCreatorOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}

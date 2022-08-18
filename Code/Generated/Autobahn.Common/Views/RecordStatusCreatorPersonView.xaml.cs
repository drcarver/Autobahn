//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusCreatorPersonView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RecordStatusCreatorPersonView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordStatusCreatorPersonView : ContentPage
    {
        /// <summary>
        /// Inject the IRecordStatusCreatorPerson View Model as the data context for the view
        /// </summary>
        public RecordStatusCreatorPersonView(Interfaces.IRecordStatusCreatorPerson vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonBirthplaceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonBirthplaceView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonBirthplace View Model as the data context for the view
        /// </summary>
        public PersonBirthplaceView(Interfaces.IPersonBirthplace vm)
        {
            BindingContext  = vm;
        }
    }
}

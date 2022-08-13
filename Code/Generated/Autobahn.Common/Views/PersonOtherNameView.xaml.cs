//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonOtherNameView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonOtherNameView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonOtherName View Model as the data context for the view
        /// </summary>
        public PersonOtherNameView(Interfaces.IPersonOtherName vm)
        {
            BindingContext  = vm;
        }
    }
}

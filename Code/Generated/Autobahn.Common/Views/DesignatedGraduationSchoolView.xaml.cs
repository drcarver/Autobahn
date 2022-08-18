//**********************************************************
//* DomainName: Common Models
//* FileName:   DesignatedGraduationSchoolView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The DesignatedGraduationSchoolView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DesignatedGraduationSchoolView : ContentPage
    {
        /// <summary>
        /// Inject the IDesignatedGraduationSchool View Model as the data context for the view
        /// </summary>
        public DesignatedGraduationSchoolView(Interfaces.IDesignatedGraduationSchool vm)
        {
            BindingContext  = vm;
        }
    }
}

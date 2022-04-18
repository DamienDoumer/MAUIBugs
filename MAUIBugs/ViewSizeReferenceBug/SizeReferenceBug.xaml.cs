using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBugs.ViewSizeReferenceBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SizeReferenceBug : ContentPage
    {
        public SizeReferenceBug()
        {
            InitializeComponent();
        }
    }
}
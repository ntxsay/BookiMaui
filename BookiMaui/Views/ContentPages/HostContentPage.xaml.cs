using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookiMaui.ViewModels.ContentPages;

namespace BookiMaui.Views.ContentPages;

public partial class HostContentPage : ContentPage
{
    public HostContentPage()
    {
        InitializeComponent();
        BindingContext = new HostContentPageViewModel();
    }
}
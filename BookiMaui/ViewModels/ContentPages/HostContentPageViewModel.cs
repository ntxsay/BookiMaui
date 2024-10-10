using System.Collections.ObjectModel;
using BookiMaui.ViewModels.Objects;
using BookiMaui.Views.ContentPages;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BookiMaui.ViewModels.ContentPages;

public class HostContentPageViewModel : ObservableObject
{
    public HostContentPageViewModel()
    {
        Filters.Add(new FilterItemViewModel()
        {
            Name = "Economique",
            ImageSource = ImageSource.FromFile("money.png")
        });
        Filters.Add(new FilterItemViewModel()
        {
            Name = "Familial",
            ImageSource = ImageSource.FromFile("family.png")
        });
        Filters.Add(new FilterItemViewModel()
        {
            Name = "Romantique",
            ImageSource = ImageSource.FromFile("romantic.png")
        });
        Filters.Add(new FilterItemViewModel()
        {
            Name = "Nos pépites" ,
            ImageSource = ImageSource.FromFile("fire.png")
        });
    }

    public ObservableCollection<FilterItemViewModel> Filters { get; } = [];
}
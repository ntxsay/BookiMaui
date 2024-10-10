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
        
        PopularHosts.Add(new HostItemViewModel()
        {   
            Name = "Hôtel Le soleil du matin",
            Price = 128,
            ImageSource = ImageSource.FromFile("emile_guillemot.jpg")
        });

        PopularHosts.Add(new HostItemViewModel()
        {   
            Name = "Chambres d’hôtes Au cœur de l’eau",
            Price = 71,
            ImageSource = ImageSource.FromFile("aw_creative.jpg")
        });
        
        PopularHosts.Add(new HostItemViewModel()
        {   
            Name = "Hôtel Bleu et Blanc",
            Price = 68,
            ImageSource = ImageSource.FromFile("febrian_zakaria2.jpg")
        });
    }

    public ObservableCollection<FilterItemViewModel> Filters { get; } = [];
    
    public ObservableCollection<HostItemViewModel> PopularHosts { get; } = [];
}
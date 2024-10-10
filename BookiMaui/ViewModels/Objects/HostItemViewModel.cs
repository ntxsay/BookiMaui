using CommunityToolkit.Mvvm.ComponentModel;

namespace BookiMaui.ViewModels.Objects;

public class HostItemViewModel : ObservableObject
{
    private ImageSource _imageSource = ImageSource.FromFile("location_dot_solid.png");
    public ImageSource ImageSource
    {
        get => _imageSource;
        set => SetProperty(ref _imageSource, value);
    }
    
    private double _price = 0;
    public double Price
    {
        get => _price;
        set => SetProperty(ref _price, value);
    }

    private string _name = string.Empty;
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    private double _rating = 0;
    public double Rating
    {
        get => _rating;
        set => SetProperty(ref _rating, value);
    }
}
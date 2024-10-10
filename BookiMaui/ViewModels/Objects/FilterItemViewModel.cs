using CommunityToolkit.Mvvm.ComponentModel;

namespace BookiMaui.ViewModels.Objects;

public class FilterItemViewModel : ObservableObject
{
    private string _name = string.Empty;
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }
    
    private ImageSource _imageSource = ImageSource.FromFile("location_dot_solid.png");
    public ImageSource ImageSource
    {
        get => _imageSource;
        set => SetProperty(ref _imageSource, value);
    }
}
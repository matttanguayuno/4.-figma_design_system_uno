using Uno.Extensions.Navigation;

namespace figma_design_system_uno.Presentation;

public partial record AvatarModel
{
    private INavigator _navigator;

    public AvatarModel(INavigator navigator)
    {
        _navigator = navigator;
    }
}

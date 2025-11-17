
namespace figma_design_system_uno.Presentation;

public record ComponentCard(string Icon, string Title, string Description, AsyncRelayCommand NavigateCommand);

public partial record HomeModel
{
    public ComponentCard[] ComponentCards { get; private set; }

    public async Task GoToAvatar()
    {
        await _navigator.NavigateViewModelAsync<AvatarModel>(this);
    }

    public async Task GoToButtons()
    {
        await _navigator.NavigateViewModelAsync<ButtonsModel>(this);
    }
    public async Task GoToCards()
    {
        await _navigator.NavigateViewModelAsync<CardsModel>(this);
    }

    public async Task GoToCheckboxFields()
    {
        await _navigator.NavigateViewModelAsync<CheckboxFieldsModel>(this);
    }
    public async Task GoToInputFields()
    {
        await _navigator.NavigateViewModelAsync<InputFieldsModel>(this);
    }

    public async Task GoToSwitchFields()
    {
        await _navigator.NavigateViewModelAsync<SwitchFieldModel>(this);
    }
    public async Task GoToRadioFields()
    {
        await _navigator.NavigateViewModelAsync<RadioFieldModel>(this);
    }

    public async Task GoToSelectField()
    {
        await _navigator.NavigateViewModelAsync<SelectFieldModel>(this);
    }
    public async Task GoToTextareaField()
    {
        await _navigator.NavigateViewModelAsync<TextareaFieldModel>(this);
    }

    public async Task GoToSearch()
    {
        await _navigator.NavigateViewModelAsync<SearchModel>(this);
    }
    private INavigator _navigator;
    public async Task GoToTag()
    {
        await _navigator.NavigateViewModelAsync<TagModel>(this);
    }

    public HomeModel(INavigator navigator)
    {
        _navigator = navigator;
        ComponentCards = new[]
        {
            new ComponentCard(
                Icon: "\uE77B",
                Title: "Avatar",
                Description: "User profile images and initials in circle and square shapes with three sizes.",
                NavigateCommand: new AsyncRelayCommand(GoToAvatar)
            ),
            new ComponentCard(
                Icon: "\uE8A1",
                Title: "Buttons",
                Description: "Explore all button variants including Primary, Neutral, and Subtle styles in Medium and Small sizes with hover and disabled states.",
                NavigateCommand: new AsyncRelayCommand(GoToButtons)
            ),
            new ComponentCard(
                Icon: "\uE8D4",
                Title: "Cards",
                Description: "Discover card components with icon and image variants, stroke and default borders, and horizontal or vertical layouts.",
                NavigateCommand: new AsyncRelayCommand(GoToCards)
            ),
            new ComponentCard(
                Icon: "\uE73A",
                Title: "Checkbox",
                Description: "Explore checkbox fields with Default and Disabled states, supporting Unchecked, Checked, and Indeterminate values with optional descriptions.",
                NavigateCommand: new AsyncRelayCommand(GoToCheckboxFields)
            ),
            new ComponentCard(
                Icon: "\uE70F",
                Title: "Input",
                Description: "Text input fields with Default, Error, and Disabled states. Supports placeholder and filled values with optional labels, descriptions, and error messages.",
                NavigateCommand: new AsyncRelayCommand(GoToInputFields)
            ),
            new ComponentCard(
                Icon: "\uE915",
                Title: "Radio",
                Description: "Radio buttons with Default and Disabled states. Supports checked and unchecked values with optional labels and descriptions.",
                NavigateCommand: new AsyncRelayCommand(GoToRadioFields)
            ),
            new ComponentCard(
                Icon: "\uE721",
                Title: "Search",
                Description: "Search input with rounded borders in Default and Disabled states. Displays search or clear icons based on input state.",
                NavigateCommand: new AsyncRelayCommand(GoToSearch)
            ),
            new ComponentCard(
                Icon: "\uE8B7",
                Title: "Select",
                Description: "Dropdown select fields with Default, Error, and Disabled states supporting placeholder and selected values.",
                NavigateCommand: new AsyncRelayCommand(GoToSelectField)
            ),
            new ComponentCard(
                Icon: "\uE71C",
                Title: "Switch",
                Description: "Toggle switches with Default and Disabled states. Supports checked and unchecked values with optional labels and descriptions.",
                NavigateCommand: new AsyncRelayCommand(GoToSwitchFields)
            ),
            new ComponentCard(
                Icon: "\uE8EC",
                Title: "Tag",
                Description: "Colored labels with Brand, Neutral, Positive, Danger, and Warning schemes. Available in Primary and Secondary variants with removable icons.",
                NavigateCommand: new AsyncRelayCommand(GoToTag)
            ),
            new ComponentCard(
                Icon: "\uE001",
                Title: "Tag Toggle",
                Description: "Toggleable tag with active/inactive states, checkmark, and Figma-matching style.",
                NavigateCommand: new AsyncRelayCommand(GoToTagToggle)
            ),
            new ComponentCard(
                Icon: "\uE70F",
                Title: "Textarea",
                Description: "Multi-line text input fields with Default, Error, and Disabled states. Supports placeholder and filled values with resizable text area.",
                NavigateCommand: new AsyncRelayCommand(GoToTextareaField)
            )
        };
    }

    public async Task GoToTagToggle()
    {
        await _navigator.NavigateViewModelAsync<TagToggleModel>(this);
    }
}

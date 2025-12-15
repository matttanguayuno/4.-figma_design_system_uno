# Uno.Themes.SDS

Simple Design System (SDS) theme for Uno Platform applications.

## Overview

Uno.Themes.SDS is a theme library that implements the **Figma Simple Design System** for Uno Platform apps. It provides Material-compatible styling, using the same resource keys and style names as `Uno.Themes.Material`, making it a **drop-in replacement**.

## Features

- ✅ **Material-compatible naming** - Uses same resource keys as Uno.Themes.Material
- ✅ **Based on Figma SDS** - Implements the Simple Design System specification
- ✅ **Swappable** - Switch between Material and SDS themes without code changes
- ✅ **Comprehensive** - Colors, brushes, thickness, and control styles
- ✅ **Multi-platform** - Supports all Uno Platform targets

## Installation

### From NuGet (Future)
```bash
dotnet add package Uno.Themes.SDS
```

### From Local Build
```bash
dotnet add reference path/to/Uno.Themes.SDS/Uno.Themes.SDS.csproj
```

## Usage

### 1. Add theme to App.xaml

```xaml
<Application ...>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="ms-appx:///Uno.Themes.SDS/SDSTheme.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

### 2. Use Material-style naming in your controls

```xaml
<!-- Filled Button (Primary in SDS) -->
<Button Content="Save" Style="{StaticResource FilledButtonStyle}" />

<!-- Outlined Button (Neutral in SDS) -->
<Button Content="Cancel" Style="{StaticResource OutlinedButtonStyle}" />

<!-- Text Button (Subtle in SDS) -->
<Button Content="Learn More" Style="{StaticResource TextButtonStyle}" />
```

### 3. Size Variants

```xaml
<!-- Small -->
<Button Content="Small" Style="{StaticResource FilledButtonSmallStyle}" />

<!-- Default/Medium -->
<Button Content="Default" Style="{StaticResource FilledButtonStyle}" />

<!-- Large -->
<Button Content="Large" Style="{StaticResource FilledButtonLargeStyle}" />
```

## Available Styles

### Button Styles
- `FilledButtonStyle` - Filled background (Primary in SDS)
- `OutlinedButtonStyle` - Outlined/border only (Neutral in SDS)
- `TextButtonStyle` - Text only (Subtle in SDS)
- Size variants: `*SmallStyle`, `*LargeStyle`

### TextBox Styles
- `FilledTextBoxStyle` - Default filled input
- `OutlinedTextBoxStyle` - Outlined input (same as Filled for SDS)

### CheckBox, RadioButton, ToggleSwitch
These controls use **theme resource overrides** - just use the default Uno Platform controls and they automatically inherit SDS styling!

```xaml
<!-- These work automatically with SDS theme -->
<CheckBox Content="Accept terms" />
<RadioButton Content="Option 1" GroupName="group1" />
<ToggleSwitch />
```

### Resource Keys (Material-compatible)

#### Colors
- `MaterialPrimaryColor`, `MaterialPrimaryBrush`
- `MaterialOnPrimaryColor`, `MaterialOnPrimaryBrush`
- `MaterialSurfaceColor`, `MaterialSurfaceBrush`
- `MaterialOnSurfaceColor`, `MaterialOnSurfaceBrush`
- `MaterialOutlineColor`, `MaterialOutlineBrush`
- `MaterialErrorColor`, `MaterialErrorBrush`
- `MaterialDisabledColor`, `MaterialDisabledBrush`

#### Thickness/Sizing
- `MaterialButtonCornerRadius` - 8px rounded corners
- `MaterialButtonPadding` - 16,12 padding
- `MaterialButtonHeight` - 40px default height
- `MaterialBorderThickness` - 1px borders

## Design Tokens

Based on Figma Simple Design System:

### Colors
- **Primary/Brand**: `#2c2c2c` (dark charcoal)
- **Primary Hover**: `#1e1e1e` (darker)
- **Surface**: `#ffffff` (white)
- **Background Secondary**: `#f5f5f5` (light gray)
- **Text Default**: `#1e1e1e` (dark gray)
- **Text Secondary**: `#757575` (medium gray)
- **Disabled**: `#b3b3b3` (light gray)
- **Error**: `#900b09` (red)

### Spacing
- Follows 8pt grid: 4px, 8px, 12px, 16px, 24px, 32px, 48px, 64px

### Corner Radius
- Default: **8px** for most controls
- Pills/Chips: **9999px** (full rounded)

## Roadmap

✅ **Complete** - All SDS components implemented:
- [x] Colors and Brushes (Material-compatible)
- [x] Typography (All text styles)
- [x] Button (Filled, Outlined, Text) with size variants
- [x] CheckBox (theme resource overrides)
- [x] RadioButton (theme resource overrides)
- [x] TextBox (Filled, Outlined styles)
- [x] ToggleSwitch (theme resource overrides)
- [x] Card (with Uno Toolkit)
- [x] Avatar (Circle and Square variants, all sizes)
- [x] Tag (Brand, Neutral, Positive, Danger, Warning schemes)
- [x] TagToggle
- [x] Search (AutoSuggestBox)
- [x] ComboBox/SelectField
- [x] TextArea (multi-line TextBox)

✅ **Integrated** - Demo app now uses the library

## Contributing

This library is part of the Figma SDS implementation for Uno Platform. Contributions welcome!

## License

TBD

## Credits

Based on the Figma Simple Design System. Built for Uno Platform.

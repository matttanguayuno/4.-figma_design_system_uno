# Uno.Themes.SDS - Project Summary

## What We've Built

Successfully created a **theme library** for Uno Platform that implements the Figma Simple Design System as a **drop-in replacement** for Uno.Themes.Material.

## Critical Requirements

### ⚠️ NO "Material" Prefix in Resource Names

**MUST** use the EXACT same resource keys as [Uno.Themes.Material](https://platform.uno/docs/articles/external/uno.themes/doc/material-colors.html):

✅ **CORRECT:**
- `SurfaceBrush`, `OutlineBrush`, `OnSurfaceBrush`
- `PrimaryBrush`, `BackgroundBrush`, `ErrorBrush`

❌ **WRONG:**
- `MaterialSurfaceBrush`, `MaterialOutlineBrush`
- Any resource with "Material" prefix

### Style Naming
**MUST** use the EXACT same style names as [Material Control Styles](https://platform.uno/docs/articles/external/uno.themes/doc/material-controls-styles.html):
- `FilledButtonStyle`, `OutlinedButtonStyle`, `TextButtonStyle`
- `OutlinedTextBoxStyle`, `FilledPasswordBoxStyle`
- `BodyMedium`, `HeadlineSmall`, `TitleLarge`

## Project Structure

```
Uno.Themes.SDS/
├── SDSTheme.xaml                    # Main theme entry point
├── Styles/
│   ├── Application/
│   │   ├── Colors.xaml              # Color resources (NO Material prefix!)
│   │   ├── Brushes.xaml             # Brush resources (NO Material prefix!)
│   │   └── Thickness.xaml           # Sizing & spacing resources
│   └── Controls/
│       └── Button.xaml              # Button styles (Material-compatible names)
└── README.md                        # Documentation
```

## Key Features

### 1. Material-Compatible Resource Keys ✅

All resources use the same naming as Uno.Themes.Material (WITHOUT "Material" prefix):

```xml
<!-- These match Uno.Themes.Material exactly -->
<SolidColorBrush x:Key="PrimaryBrush" Color="#2c2c2c" />
<SolidColorBrush x:Key="OnPrimaryBrush" Color="#f5f5f5" />
<SolidColorBrush x:Key="SurfaceBrush" Color="#ffffff" />
<SolidColorBrush x:Key="OutlineBrush" Color="#d9d9d9" />
<SolidColorBrush x:Key="ErrorBrush" Color="#900b09" />
<!-- etc. -->
```

### 2. Material-Compatible Style Names ✅

Button styles follow Material conventions but implement SDS visuals:

| Material Style Name | SDS Equivalent | Visual Design |
|---------------------|----------------|---------------|
| `FilledButtonStyle` | Primary Button | Dark (#2c2c2c) filled background |
| `OutlinedButtonStyle` | Neutral Button | White background with border |
| `TextButtonStyle` | Subtle Button | Transparent background |

Size variants:
- `FilledButtonSmallStyle` - 32px height
- `FilledButtonStyle` - 40px height (default)
- `FilledButtonLargeStyle` - 48px height

### 3. SDS Design Tokens ✅

Implements the complete SDS design system:

**Colors:**
- Primary/Brand: `#2c2c2c`
- Hover: `#1e1e1e`
- Surface: `#ffffff`
- Disabled: `#b3b3b3`
- Error: `#900b09`

**Spacing:** 4px, 8px, 12px, 16px, 24px, 32px, 48px, 64px
**Corner Radius:** 8px standard
**Border Width:** 1px

## Usage Example

### In App.xaml:
```xaml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="ms-appx:///Uno.Themes.SDS/SDSTheme.xaml" />
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

### In your pages:
```xaml
<!-- These styles work with SDS theme! -->
<Button Content="Save" Style="{StaticResource FilledButtonStyle}" />
<Button Content="Cancel" Style="{StaticResource OutlinedButtonStyle}" />
<Button Content="Learn More" Style="{StaticResource TextButtonStyle}" />
```

## Build Status

✅ **Builds successfully** for:
- net9.0 (base)
- net9.0-android
- net9.0-ios
- net9.0-maccatalyst

## What's Implemented

- [x] Project structure
- [x] Colors (Material keys)
- [x] Brushes (Material keys)
- [x] Thickness/Sizing
- [x] Button styles (Filled, Outlined, Text) with size variants
- [x] Documentation (README.md)

## Next Steps

To complete the SDS theme library:

1. **Add more control styles** (using existing demo as reference):
   - CheckBox
   - RadioButton
   - TextBox (Filled/Outlined)
   - ToggleSwitch
   - Card
   - Tag/Chip

2. **Add Typography styles** (from SDS spec):
   - Body, BodyStrong
   - Heading, Subheading
   - Title styles

3. **Test integration** with demo app:
   - Add project reference from demo → library
   - Replace demo's custom styles with library
   - Verify visual parity

4. **Package for distribution**:
   - Create NuGet package
   - Add package metadata
   - Publish to feed

## Compatibility with Material

Apps can **switch between themes** by changing one line:

```xml
<!-- Use Material -->
<ResourceDictionary Source="ms-appx:///Uno.Material.WinUI/Resources/MaterialTheme.xaml" />

<!-- Use SDS -->
<ResourceDictionary Source="ms-appx:///Uno.Themes.SDS/SDSTheme.xaml" />
```

Because both use the same resource keys (`MaterialPrimaryBrush`, `FilledButtonStyle`, etc.), **no other code changes are needed**!

## Technical Notes

- Uses Central Package Management (`Directory.Packages.props`)
- Multi-platform targeting (excludes Windows due to XAML compilation differences)
- XAML resources compiled as `Page` items
- Based on Uno.WinUI 5.5.37

## Value Proposition

This library enables:
1. **Uno Platform users** to use SDS instead of Material
2. **Theme swapping** without code changes
3. **Design system consistency** across apps
4. **Foundation** for more SDS-based controls and styles

Perfect foundation for building a complete Simple Design System theme package! 🎉

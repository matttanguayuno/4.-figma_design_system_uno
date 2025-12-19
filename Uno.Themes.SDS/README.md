# Uno.Themes.SDS

Simple Design System (SDS) theme for Uno Platform applications.

## Overview

Uno.Themes.SDS is a theme library that implements the **Figma Simple Design System** for Uno Platform apps. It provides **drop-in replacement** for `Uno.Themes.Material`, using the exact same resource keys and style names.

## Features

- ✅ **Material-compatible naming** - Uses EXACT same resource keys as Uno.Themes.Material (without "Material" prefix)
- ✅ **Based on Figma SDS** - Implements the Simple Design System specification  
- ✅ **Swappable** - True drop-in replacement - switch between Material and SDS themes without code changes
- ✅ **Comprehensive** - Colors, brushes, thickness, control styles, and **reusable components**
- ✅ **Multi-platform** - Supports all Uno Platform targets
- ✅ **Reusable Components** - Pre-built card components (Pricing, Product, Review, Stats, Testimonial) ready to use

## Key Principles

### Resource Naming
- Uses **EXACT same keys** as [Uno.Themes.Material](https://platform.uno/docs/articles/external/uno.themes/doc/material-colors.html)
- **NO "Material" prefix** in resource names
- Examples: `SurfaceBrush`, `OutlineBrush`, `OnSurfaceBrush` (NOT `MaterialSurfaceBrush`)

### Style Naming  
- Uses **EXACT same style names** as [Material Control Styles](https://platform.uno/docs/articles/external/uno.themes/doc/material-controls-styles.html)
- Examples: `FilledButtonStyle`, `OutlinedTextBoxStyle`, `BodyMedium`

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

### 4. Reusable Card Components

The library includes pre-built, customizable card components:

```xaml
<!-- Add namespace -->
xmlns:sds="using:Uno.Themes.SDS.Controls"

<!-- Pricing Card (Desktop Layout, Light Style) -->
<sds:PricingCard Title="Pro Plan"
                 Price="50"
                 Period=" / mo"
                 Features="{x:Bind FeaturesList}"
                 ButtonText="Subscribe"
                 Style="{StaticResource LightDesktopPricingCardStyle}" />

<!-- Pricing Card (Mobile Layout, Branded Style) -->
<sds:PricingCard Title="Enterprise"
                 Price="199"
                 Features="{x:Bind FeaturesList}"
                 Style="{StaticResource BrandedMobilePricingCardStyle}" />

<!-- Product Info Card -->
<sds:ProductInfoCard ProductName="Product Name"
                     Price="$99"
                     Description="Product description"
                     ImageSource="https://..." />

<!-- Review Card -->
<sds:ReviewCard Rating="5"
                ReviewTitle="Great Product!"
                ReviewBody="I love this product..."
                ReviewerName="John Doe"
                ReviewDate="Dec 2025"
                ReviewerImage="https://..." />

<!-- Stats Card -->
<sds:StatsCard IconGlyph="&#xE823;"
               Value="1,234"
               Label="Total Users" />

<!-- Testimonial Card -->
<sds:TestimonialCard Quote="&quot;This changed everything!&quot;"
                     AuthorName="Jane Smith"
                     AuthorTitle="CEO, Company"
                     AuthorImage="https://..." />
```

## Available Styles

### Reusable Components

#### Card Components
- `PricingCard` - Pricing plans with features list
  - Styles: `LightDesktopPricingCardStyle`, `BrandedDesktopPricingCardStyle`, `LightMobilePricingCardStyle`, `BrandedMobilePricingCardStyle`
  - Properties: `Title`, `Price`, `Period`, `Features` (IList<string>), `ButtonText`, `IsBranded`, `LayoutVariant`
- `ProductInfoCard` - Product display with image, name, price, description
  - Properties: `ProductName`, `Price`, `Description`, `ImageSource`
- `ReviewCard` - Customer reviews with star rating and reviewer info
  - Properties: `Rating` (1-5), `ReviewTitle`, `ReviewBody`, `ReviewerName`, `ReviewDate`, `ReviewerImage`
- `StatsCard` - Statistics display with icon, value, and label
  - Properties: `IconGlyph`, `Value`, `Label`
- `TestimonialCard` - Customer testimonials with quote and author
  - Properties: `Quote`, `AuthorName`, `AuthorTitle`, `AuthorImage`

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

- [x] **Reusable Card Components** (PricingCard, ProductInfoCard, ReviewCard, StatsCard, TestimonialCard)
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

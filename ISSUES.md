# Known Issues

This document tracks known issues and bugs that need to be fixed.

## ✅ Recently Resolved

### Hardcoded Colors Moved to Library (RESOLVED)
**Status:** ✅ FIXED - All hardcoded colors have been moved to Uno.Themes.SDS library resources

**What Was Done:**
- Added comprehensive color palette to `Uno.Themes.SDS/Styles/Application/Colors.xaml`
- Added corresponding brushes to `Uno.Themes.SDS/Styles/Application/Brushes.xaml`
- Created reusable Menu component styles in `Uno.Themes.SDS/Controls/MenuItem.xaml`
- Updated MenuPage.xaml to use library resources instead of hardcoded colors
- Updated HomePage.xaml to use library resources for cards and buttons

**New Resources Added:**
- Menu colors: SDSMenuBackgroundBrush, SDSMenuBorderBrush, SDSMenuItemHoverBackgroundBrush, etc.
- Slider colors: SDSSliderTrackBrush, SDSSliderFillBrush, SDSSliderHandleBrush, etc.
- Input colors: SDSInputBackgroundBrush, SDSInputBorderBrush, SDSInputDisabledBackgroundBrush, etc.
- RadioButton colors: SDSRadioOuterRingDefaultBrush, SDSRadioInnerDotBrush, etc.
- Card colors: SDSCardBorderBrush, SDSCardBackgroundLightBrush
- Dialog colors: SDSDialogBorderBrush, SDSDialogScrimBrush, SDSSecondaryButtonBackgroundBrush

### Obsolete Pages Removed (RESOLVED)
**Status:** ✅ FIXED - Consolidated into Input Fields page

**What Was Done:**
- Deleted RadioFieldPage, SearchPage, SelectFieldPage, SwitchFieldPage, TextareaFieldPage
- Removed references from App.xaml.cs, Shell.xaml.cs, and HomeModel.cs
- All components now accessible through single InputFieldsPage

---

## 🔴 High Priority

### Add Interactive Control for State Demonstrations
**Location:** All component pages (Buttons, Tags, etc.)

**Issue:** Component showcase pages currently display all states (default, hover, active, disabled) as static examples. There's no way for users to interact with a control to see the state changes happen in real-time.

**Expected Behavior:** Add interactive demo controls that allow users to hover over or click components to see live state transitions and animations, making it easier to understand how components behave in actual use.

**Proposed Solution:** Create interactive demo sections in addition to the static state matrices, where users can interact with buttons, tags, and other controls to see hover effects, click feedback, and state transitions.

### Menu Page - Wrong Up Arrow in Chrome (WebAssembly)
**Location:** `figma_design_system_uno/Presentation/MenuPage.xaml` - Menu section

**Issue:** Unicode arrow characters (↑, ⇧, ⬆, etc.) do not render in Chrome browser when running WebAssembly build, even with explicit font families like Arial or Segoe UI Symbol. The characters display as empty boxes or missing glyphs.

**Current Workaround:** Using FontIcon with Segoe MDL2 Assets glyph `&#xE74A;` which renders correctly but displays a different arrow style than intended.

**Expected Behavior:** Display a proper upward arrow symbol (↑) followed by the letter "A" to represent keyboard shortcut "Shift+A"

**Actual Behavior:** Text-based arrows don't render; using FontIcon &#xE74A; as temporary solution but the arrow style doesn't perfectly match design intent.

**Notes:** 
- Works perfectly in desktop build (net9.0-desktop)
- Issue specific to WebAssembly/browser fonts

---

## 🟡 Medium Priority

### Bold Text Not Bold Enough Across Pages
**Location:** Multiple pages - NavigationPage.xaml and other component pages

**Issue:** Section headers and matrix identifier labels (e.g., "Small", "Medium", "Default", "Hover", "Active", "Row", "Column") use FontWeight="SemiBold" or BodyStrongTextBlockStyle but do not appear bold enough to create proper visual hierarchy.

**Expected Behavior:** Bold text should stand out more prominently to clearly distinguish section headers and state labels from body text

**Actual Behavior:** Current bold text lacks sufficient weight to create clear visual distinction

**Notes:** 
- Applies to NavigationPage.xaml and potentially all other component showcase pages
- May need FontWeight="Bold" instead of "SemiBold" or custom TextBlock style with heavier weight
- May require embedding custom web fonts or finding alternative icon font solution

### CheckBox Disabled Glyph Color - ThemeResource Not Working
**Location:** `figma_design_system_uno/Presentation/InputFieldsPage.xaml` (Grid Row 2 Columns 1 & 3)

**Issue:** ThemeResource binding fails specifically for `Path.Fill` property in CheckBox visual states. While `Rectangle.Fill` and `Rectangle.Stroke` work correctly with ThemeResource, the `Path.Fill` for the checkmark and dash glyphs does not resolve the resource.

**Current Workaround:** Hardcoded `Fill="#B3B3B3"` in inline ControlTemplates for Disabled Checked and Disabled Indeterminate states.

**Expected Behavior:** 
```xaml
<Path Fill="{ThemeResource CheckBoxGlyphForegroundCheckedDisabled}" ... />
```
Should resolve to #B3B3B3 from the resource definition.

**Actual Behavior:** 
Path.Fill shows #F5F5F5 (OnPrimaryColor) instead of #B3B3B3 when using ThemeResource.

**Investigation Needed:**
- Test if StaticResource works instead of ThemeResource for Path.Fill
- Check if issue is specific to WASM or affects other platforms
- Review WinUI/Uno documentation for visual state setter limitations with Path elements
- Consider filing bug report with Uno Platform if ThemeResource should work

---

## 🟡 Medium Priority

### PricingCard Button Colors Wrong
**Location:** `figma_design_system_uno/Presentation/CardsPage.xaml` (PricingCard components)

**Issue:** Button colors in PricingCard components are not matching the Figma design despite color resources being verified as correct.

**Current State:** Button colors are wrong in both light and dark card variants.

**Investigation Needed:**
- May be related to same ThemeResource binding issue as CheckBox glyphs
- Consider diagnostic test with hardcoded button colors similar to CheckBox approach
- Verify which specific button properties are failing (Background, Foreground, BorderBrush)

### TextBox Placeholder Text Not Visible (White on White)
**Location:** `figma_design_system_uno/Presentation/InputFieldsPage.xaml` (Input Field section, column 2 "Placeholder")

**Issue:** Placeholder text in TextBox controls is not visible - appears to be white text on white background.

**Current State:** TextBox resources defined in `Uno.Themes.SDS/Styles/Controls/TextBox.xaml` with `TextControlPlaceholderForeground` set to `MaterialOnSurfaceLowColor`, but not being applied correctly.

**Investigation Needed:**
- May need custom TextBox ControlTemplate similar to CheckBox solution
- Verify if ThemeResource binding fails for PlaceholderForeground (similar to Path.Fill issue)

### Menu Page - Missing Separator Lines
**Location:** `figma_design_system_uno/Presentation/MenuPage.xaml` (Menu section)

**Issue:** Separator lines between menu sections are not rendering/visible in the Menu component.

**Current State:** 
- Rectangle separators with Fill="#d9d9d9" and Height="1" are placed in the XAML
- Menu Separator section displays separator line correctly
- Same code in Menu section (inside AutoLayout) does not render

**Investigation Needed:**
- AutoLayout may not be rendering 1px height Rectangles properly
- May need to use Border with BorderThickness instead of Rectangle with Fill
- Test if issue is specific to nested AutoLayout containers
- Check if placeholder color resource is using correct color value
- Consider inline TextBox template with hardcoded PlaceholderForeground as workaround

### Button Hover Effects Not Visible (White on White)
**Location:** Various buttons throughout the application

**Issue:** Button hover effects disappear - white content on white background when hovering.

**Investigation Needed:**
- Check hover state visual state definitions in button styles
- Verify ThemeResource bindings for hover state colors
- May be related to same ThemeResource binding issue affecting other controls
- Test with hardcoded hover colors as diagnostic

### Font Properties Should Use Variables
**Location:** Throughout the application

**Issue:** Font family, size, and weight are currently hardcoded in various places instead of using theme variables/resources.

**Impact:** Difficult to maintain consistent typography across the design system. Changes to font properties require updating multiple files.

**Investigation Needed:**
- Audit all hardcoded FontFamily, FontSize, and FontWeight values
- Create centralized font variables/resources in theme
- Update all instances to use the variables
- Ensure proper inheritance and fallback behavior

### Bold Sections of All Pages
**Location:** All presentation pages (AccordionPage, AvatarPage, ButtonsPage, CardsPage, DialogPage, InputFieldsPage, TagPage, TagTogglePage, etc.)

**Issue:** Section headings use `HeadingTextBlockStyle` which makes them larger but not bold enough. Added `FontWeight="Bold"` to override the style, but this is a workaround.

**Current State:** All section headings now have `FontWeight="Bold"` placed before the Style attribute to ensure proper override.

**Investigation Needed:**
- Consider updating `HeadingTextBlockStyle` to include Bold font weight by default
- Evaluate if section headings should use a different dedicated style (e.g., `SectionHeadingTextBlockStyle`)
- Review design system for proper heading hierarchy and typography

### Matrix Identifier Styles
**Location:** All input field sections with matrix layouts (Checkbox Field, Radio Field, Switch Field, Input Field, Select Field, Search, Slider Field, Textarea)

**Issue:** Matrix row and column identifiers currently use plain TextBlock elements. According to Figma design, they should be styled as rounded rectangles with lines for better visual hierarchy.

**Current State:** Using basic TextBlock with BodyStrongTextBlockStyle for row/column labels (e.g., "Default", "Disabled", "Checked", "Unchecked").

**Investigation Needed:**
- Review Figma design for exact specifications (corner radius, line thickness, colors)
- Create reusable style or control template for matrix identifiers
- Update all matrix layouts to use the new identifier style
- Ensure consistent spacing and alignment with new design

### Rounded Dotted Rectangles Around Matrix Examples
**Location:** All pages with matrix layouts (NavigationPage, MenuPage, ButtonsPage, CardsPage, InputFieldsPage, AccordionPage, AvatarPage, etc.)

**Issue:** Dotted rectangles around matrix examples should have rounded corners to match the design system's aesthetic. Currently using Rectangle with StrokeDashArray but no corner radius support.

**Current State:** ButtonsPage has dotted rectangles with sharp corners. Other pages may need similar visual separation between identifying labels and actual control examples.

**Investigation Needed:**
- WinUI Rectangle does not support CornerRadius property
- May need to use Border with dashed BorderBrush (if supported) or Path element to create rounded dotted rectangles
- Apply rounded dotted rectangles to all matrix layouts across all pages
- Ensure consistent corner radius matching other design system elements

### Tooltip Page - Cannot Resize Tooltips
**Location:** `figma_design_system_uno/Presentation/TooltipPage.xaml`

**Issue:** TeachingTip control has a hardcoded minimum width of 320px in its implementation (`s_defaultTipHeightAndWidth = 320` constant in source code). Attempts to control width through:
- Direct properties: Width, MinWidth, MaxWidth
- Style setters: MinWidth, MaxWidth, HorizontalAlignment
- Resource overrides: TeachingTipMinWidth, TeachingTipMaxWidth

All approaches are ignored by the control's internal layout logic.

**Current State:** Layout changed to vertical (one per row) to avoid overlap issues, but tooltips remain wider than desired.

**Investigation Needed:**
- Determine if ControlTemplate override is necessary to access internal Grid/Border sizing
- Consider custom tooltip implementation if TeachingTip cannot be resized
- Evaluate if 320px minimum is acceptable as design constraint


**Investigation Needed:**
- Add HorizontalAlignment="Right" to all row identifier Border elements
- Ensure consistent alignment across all matrix layouts
- Review column spacing and margins after alignment changes

*(Additional issues to be added)*

---

## 🟢 Low Priority

*(To be added)*

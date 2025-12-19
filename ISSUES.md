# Known Issues

This document tracks known issues and bugs that need to be fixed.

## 🔴 High Priority

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
- Check if placeholder color resource is using correct color value
- Consider inline TextBox template with hardcoded PlaceholderForeground as workaround

*(Additional issues to be added)*

---

## 🟢 Low Priority

*(To be added)*

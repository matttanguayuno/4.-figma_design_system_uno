# Figma Design System - Extracted Information

**Figma File Key:** XCGoBNGlHZ4G1M0LKJqIZr

**Extraction Date:** November 13, 2025

## Table of Contents
1. [Design Tokens](#design-tokens)
2. [Typography System](#typography-system)
3. [Color System](#color-system)
4. [Spacing & Sizing](#spacing--sizing)
5. [Components](#components)
6. [Examples & Patterns](#examples--patterns)
7. [Icon Library](#icon-library)

---

## Design Tokens

### Colors (CSS Variables)

#### Brand Colors
- `--sds-color-background-brand-default`: `#2c2c2c`
- `--sds-color-background-brand-hover`: `#1e1e1e`
- `--sds-color-background-brand-tertiary`: `#f5f5f5`
- `--sds-color-border-brand-default`: `#2c2c2c`
- `--sds-color-text-brand-on-brand`: `#f5f5f5`
- `--sds-color-text-brand-on-brand-secondary`: `#1e1e1e`

#### Neutral/Default Colors
- `--sds-color-background-default-default`: `#ffffff`
- `--sds-color-background-default-secondary`: `#f5f5f5`
- `--sds-color-background-neutral-tertiary`: `#e3e3e3`
- `--sds-color-background-neutral-tertiary-hover`: `#cdcdcd`
- `--sds-color-border-default-default`: `#d9d9d9`
- `--sds-color-border-neutral-default`: `#303030`
- `--sds-color-border-neutral-secondary`: `#767676`
- `--sds-color-text-default-default`: `#1e1e1e`
- `--sds-color-text-default-secondary`: `#757575`
- `--sds-color-text-default-tertiary`: `#b3b3b3`
- `--sds-color-text-neutral-default`: `#303030`

#### Disabled Colors
- `--sds-color-background-disabled-default`: `#d9d9d9`
- `--sds-color-border-disabled-default`: `#b3b3b3`
- `--sds-color-border-disabled-secondary`: `#b2b2b2`
- `--sds-color-text-disabled-default`: `#b3b3b3`
- `--sds-color-text-disabled-on-disabled`: `#b3b3b3`

#### Error/Danger Colors
- `--sds-color-border-danger-default`: `#900b09`
- `--sds-color-text-danger-default`: `#900b09`

#### Slate/Placeholder
- `--sds-color-slate-200`: `#e3e3e3`

### Spacing Scale
- `--sds-size-space-050`: `2px`
- `--sds-size-space-100`: `4px`
- `--sds-size-space-200`: `8px`
- `--sds-size-space-300`: `12px`
- `--sds-size-space-400`: `16px`
- `--sds-size-space-600`: `24px`
- `--sds-size-space-800`: `32px`
- `--sds-size-space-1200`: `48px`
- `--sds-size-space-1600`: `64px`
- `--sds-size-space-4000`: `160px`

### Border Radius
- `--sds-size-radius-200`: `8px`
- `--sds-size-radius-full`: `9999px`

### Stroke/Border Width
- `--sds-size-stroke-border`: `1px`

---

## Typography System

### Font Family
**Primary Font:** Inter

### Typography Styles

#### Body Text
- **Body Base**: Font-family: Inter, Weight: 400 (Regular), Size: 16px, Line-height: 1.4
- **Body Strong**: Font-family: Inter, Weight: 600 (Semi Bold), Size: 16px, Line-height: 1.4
- **Single Line Body Base**: Font-family: Inter, Weight: 400 (Regular), Size: 16px, Line-height: 1

#### Headings
- **Heading Base**: Font-family: Inter, Weight: 600 (Semi Bold), Size: 24px, Line-height: 1.2, Tracking: -0.48px
- **Subheading Medium**: Font-family: Inter, Weight: 400 (Regular), Size: 20px, Line-height: 1.2

#### Titles
- **Title Hero**: Font-family: Inter, Weight: 700 (Bold), Size: 72px, Line-height: 1.2, Tracking: -2.16px
- **Title Page**: Font-family: Inter, Weight: 700 (Bold), Size: 48px, Line-height: 1.2
- **Subtitle Base**: Font-family: Inter, Weight: 400 (Regular), Size: 32px, Line-height: 1.2

### CSS Variables
- `--sds-typography-body-font-family`: 'Inter'
- `--sds-typography-body-font-weight-regular`: 400
- `--sds-typography-body-font-weight-strong`: 600
- `--sds-typography-body-size-medium`: 16px
- `--sds-typography-heading-font-family`: 'Inter'
- `--sds-typography-heading-font-weight`: 600
- `--sds-typography-heading-size-base`: 24px
- `--sds-typography-subheading-font-family`: 'Inter'
- `--sds-typography-subheading-font-weight`: 400
- `--sds-typography-subheading-size-medium`: 20px
- `--sds-typography-title-hero-font-family`: 'Inter'
- `--sds-typography-title-hero-font-weight`: 700
- `--sds-typography-title-hero-size`: 72px
- `--sds-typography-subtitle-font-family`: 'Inter'
- `--sds-typography-subtitle-font-weight`: 400
- `--sds-typography-subtitle-size-base`: 32px

---

## Color System

### Color Palette Summary
The design system uses a neutral color palette with a dark primary brand color (#2c2c2c) and carefully balanced grays for hierarchy.

**Key Principles:**
- High contrast for accessibility
- Clear visual hierarchy through color weight
- Consistent disabled states
- Semantic color usage (danger for errors)

---

## Spacing & Sizing

### Spacing Scale Philosophy
Follows an 8-point grid system with additional increments:
- **Micro**: 2px, 4px
- **Small**: 8px, 12px, 16px
- **Medium**: 24px, 32px
- **Large**: 48px, 64px
- **Extra Large**: 160px

---

## Components

### 1. Button Component
**Node ID:** 4185:3778

**Variants:**
- **Variant:** Primary, Neutral, Subtle
- **State:** Default, Hover, Disabled
- **Size:** Medium (40px height), Small (32px height)

**Properties:**
- Label (string)
- Icon Start (optional)
- Icon End (optional)
- Has Icon Start (boolean)
- Has Icon End (boolean)

**Styling:**
- **Primary**: Dark background (#2c2c2c), white text, 8px border-radius
- **Neutral**: Light gray background (#e3e3e3), dark text, gray border
- **Subtle**: No background, optional border on hover
- **Hover states**: Darker backgrounds
- **Disabled**: Gray background (#d9d9d9), gray text (#b3b3b3)

**Spacing:**
- Padding: 12px (Medium), 8px (Small)
- Gap between elements: 8px

---

### 2. Card Component
**Node ID:** 2142:11380

**Variants:**
- **Asset Type:** Icon, Image
- **Variant:** Default, Stroke (with border)
- **Direction:** Horizontal, Vertical

**Properties:**
- Heading (string)
- Body (string)
- Asset (boolean)
- Button (boolean)
- Icon (optional React node)

**Styling:**
- Border: 1px solid #d9d9d9 (Stroke variant)
- Border-radius: 8px
- Padding: 24px
- Gap: 24px between elements
- Background: White (#ffffff)

**Layout:**
- Min-width: 240px
- Max-width: 440px
- Flexible content arrangement

---

### 3. Input Field Component
**Node ID:** 2136:2263

**Variants:**
- **State:** Default, Error, Disabled
- **Value Type:** Default, Placeholder

**Properties:**
- Label (string)
- Value (string)
- Error (string)
- Description (string)
- Has Label (boolean)
- Has Error (boolean)
- Has Description (boolean)

**Styling:**
- Border: 1px solid #d9d9d9 (default), #900b09 (error)
- Border-radius: 8px
- Padding: 12px vertical, 16px horizontal
- Background: White (default), #d9d9d9 (disabled)
- Min-width: 240px

**Typography:**
- Input text: 16px, Regular
- Label: 16px, Regular, #1e1e1e
- Error: 16px, Regular, #900b09
- Placeholder: 16px, Regular, #b3b3b3

---

### 4. Avatar Component
**Node ID:** 9762:1103

**Variants:**
- **Type:** Image (other types possible)
- **Size:** Large (40px)
- **Shape:** Circle

**Styling:**
- Border-radius: 9999px (fully rounded)
- Size: 40px × 40px

---

### 5. Avatar Group Component
**Node ID:** 56:15608

Multiple avatars displayed together with overlap.

---

### 6. Icon Button Component
**Node ID:** 11:11508

**Properties:**
- Icon (required)
- Size variants

**Styling:**
- Padding: 8px
- Border-radius: 32px (pill-shaped)
- Compact design for icon-only actions

---

### 7. Button Group Component
**Node ID:** 2072:9432

**Variants:**
- **Align:** Justify (full width distribution)

**Properties:**
- Button Start (boolean)
- Button End (boolean)

**Styling:**
- Gap: 16px between buttons
- Flexible layout

---

### 8. Navigation Pill Component
**Node ID:** 7768:19970

**Variants:**
- **State:** Default, Active

**Properties:**
- Label (string)

**Styling:**
- Padding: 8px
- Border-radius: 8px
- Background (Active): #f5f5f5
- Text: 16px, Regular
- Color (Active): #1e1e1e

---

### 9. Navigation Pill List Component
**Node ID:** 524:503 / 2194:14984

**Variants:**
- **Direction:** Row, Column

**Properties:**
- Multiple link options (link1-link7)

**Styling:**
- Gap: 8px between pills
- Flexible wrapping

---

### 10. Text Content Heading Component
**Node ID:** 2153:7834

**Properties:**
- Heading (string)
- Subheading (string)
- Has Subheading (boolean)
- Align: Start, Center

**Styling:**
- Heading: 24px, Semi Bold, #1e1e1e
- Subheading: 20px, Regular, #757575
- Gap: 8px

---

### 11. Text Content Title Component
**Node ID:** 2153:7838

**Properties:**
- Title (string)
- Subtitle (string)
- Has Subtitle (boolean)
- Align: Center, Start

**Styling:**
- Title: 72px, Bold, #1e1e1e, Tracking: -2.16px
- Subtitle: 32px, Regular, #757575
- Gap: 8px

---

### 12. Pricing Card Component
**Node ID:** 1444:11846

Specialized card for pricing information.

---

### 13. Tag Component
**Node ID:** 56:8830

Small label/badge component.

---

### 14. Tag Toggle Component
**Node ID:** 157:10316

Interactive tag with toggle state.

---

### 15. Tooltip Component
**Node ID:** 315:32700

Contextual help overlay.

---

### 16. Notification Component
**Node ID:** 124:8256

Alert/notification banner.

---

### 17. Pagination Components
- **Next:** 9762:870
- **Previous:** 9762:880
- **Page:** 9762:890

---

### 18. Tab Component
**Node ID:** 3729:12963

Tab navigation element.

---

### 19. Accordion Item Component
**Node ID:** 7753:4634

Expandable/collapsible content section.

---

### 20. Dialog Body Component
**Node ID:** 9762:696

Modal dialog content area.

---

### 21. Form Field Components
- **Radio Field:** 9762:1412
- **Checkbox Field:** 9762:1441
- **Switch Field:** 9762:1902
- **Select Field:** 2136:2336
- **Textarea Field:** 9762:3088
- **Search:** 2236:14989
- **Slider Field:** 589:17676

---

### 22. Menu Item Component
**Node ID:** 9762:743

Individual menu item for dropdowns or lists.

---

## Examples & Patterns

### Full Page Examples

#### 1. Home Page Example
**Node ID:** 562:8332

**Platforms:** Desktop (1200px), Mobile (375px)

**Sections:**
- Header with logo and navigation
- Hero section with title, subtitle, and action buttons
- Image/content section
- Testimonial cards grid
- Footer with links

**Key Features:**
- Responsive layout
- Navigation pills (active state support)
- Button groups
- Card grids
- Social media icons

---

#### 2. About Page
**Node ID:** 562:9044

---

#### 3. Contact Us Page
**Node ID:** 562:9227

---

#### 4. Pricing Page
**Node ID:** 562:9558

---

#### 5. Waitlist Page
**Node ID:** 562:9701

---

#### 6. Landing Page
**Node ID:** 562:10124

---

#### 7. Article Page
**Node ID:** 562:10260

---

#### 8. Shop Page
**Node ID:** 562:10872

---

#### 9. Product Detail Page
**Node ID:** 562:11271

---

#### 10. Portfolio Page
**Node ID:** 562:11665

---

### Pattern Components

#### Header Component
**Node ID:** 2287:22651

**Platforms:** Desktop, Mobile
**States:** Default, Open (mobile menu)

**Features:**
- Logo placement
- Navigation pills
- Auth buttons (Sign in, Register)
- Hamburger menu (mobile)

---

#### Header Auth Component
**Node ID:** 18:9389

**States:** Logged Out, Logged In

**Buttons:**
- Sign in (Neutral button)
- Register (Primary button)

---

#### Footer Component
**Node ID:** 321:11357

**Platforms:** Desktop, Mobile

**Sections:**
- Logo and social links
- Multiple link columns
  - Use cases
  - Explore
  - Resources

**Social Icons:**
- X (Twitter)
- Instagram
- YouTube
- LinkedIn

---

### Section Patterns

#### Hero Patterns
- **Hero Basic:** 348:15896
- **Hero Actions:** 348:15901
- **Hero Newsletter:** 348:15919
- **Hero Form:** 348:15933
- **Hero Image:** 348:15970

#### Card Grid Patterns
- **Card Grid Icon:** 348:13221
- **Card Grid Image:** 348:14431
- **Card Grid Content List:** 348:13407
- **Card Grid Pricing:** 348:14983
- **Card Grid Testimonials:** 348:13347
- **Card Grid Reviews:** 348:15213

#### Panel Patterns
- **Panel Image Content:** 348:13474
- **Panel Image Content Reverse:** 348:15101
- **Panel Image:** 348:15098
- **Panel Image Double:** 348:13470

#### Page Patterns
- **Page Accordion:** 348:13173
- **Page Product:** 348:15147
- **Page Product Results:** 348:13517
- **Page Newsletter:** 348:15133

#### Text Patterns
- **Text Content Heading:** 2153:7834
- **Text Content Title:** 2153:7838
- **Text Link List:** 322:9321
- **Text List:** 480:6149
- **Text Price:** 1443:10386

---

## Icon Library

The design system includes 286 icons from the Feather icon set. All icons are available in multiple sizes: 16px, 20px, 24px, 32px, 40px, 48px.

### Complete Icon List

**A-B:**
Activity, Airplay, Alert Circle, Alert Octagon, Alert Triangle, Align Center, Align Justify, Align Left, Align Right, Anchor, Aperture, Archive, Arrow Down, Arrow Down-Circle, Arrow Down-Left, Arrow Down-Right, Arrow Left, Arrow Left-Circle, Arrow Right, Arrow Right-Circle, Arrow Up, Arrow Up-Circle, Arrow Up-Left, Arrow Up-Right, At Sign, Award, Bar Chart, Bar Chart-2, Battery, Battery Charging, Bell, Bell Off, Bluetooth, Bold, Book, Book Open, Bookmark, Box, Briefcase

**C:**
Calendar, Camera, Camera Off, Cast, Check, Check Circle, Check Square, Chevron Down, Chevron Left, Chevron Right, Chevron Up, Chevrons Down, Chevrons Left, Chevrons Right, Chevrons Up, Chrome, Circle, Clipboard, Clock, Cloud, Cloud Drizzle, Cloud Lightning, Cloud Off, Cloud Rain, Cloud Snow, Code, Codepen, Codesandbox, Coffee, Columns, Command, Compass, Copy, Corner Down-Left, Corner Down-Right, Corner Left-Down, Corner Left-Up, Corner Right-Down, Corner Right-Up, Corner Up-Left, Corner Up-Right, CPU, Credit Card, Crop, Crosshair

**D-F:**
Database, Delete, Disc, Divide, Divide Circle, Divide Square, Dollar Sign, Download, Download Cloud, Dribbble, Droplet, Edit, Edit 2, Edit 3, External Link, Eye, Eye Off, Facebook, Fast Forward, Feather, Figma, File, File Minus, File Plus, File Text, Film, Filter, Flag, Folder, Folder Minus, Folder Plus, Framer, Frown

**G-I:**
Gift, Git Branch, Git Commit, Git Merge, Git Pull-Request, GitHub, GitLab, Globe, Grid, Hard Drive, Hash, Headphones, Heart, Help Circle, Hexagon, Home, Image, Inbox, Info, Instagram, Italic

**K-M:**
Key, Layers, Layout, Life Buoy, Link, Link 2, LinkedIn, List, Loader, Lock, Log In, Log Out, Mail, Map, Map Pin, Maximize, Maximize 2, Meh, Menu, Message Circle, Message Square, Mic, Mic Off, Minimize, Minimize 2, Minus, Minus Circle, Minus Square, Monitor, Moon, More Horizontal, More Vertical, Mouse Pointer, Move, Music

**N-P:**
Navigation, Navigation 2, Octagon, Package, Paperclip, Pause, Pause Circle, Pen Tool, Percent, Phone, Phone Call, Phone Forwarded, Phone Incoming, Phone Missed, Phone Off, Phone Outgoing, Pie Chart, Play, Play Circle, Plus, Plus Circle, Plus Square, Pocket, Power, Printer

**R-S:**
Radio, Refresh CCW, Refresh CW, Repeat, Rewind, Rotate CCW, Rotate CW, RSS, Save, Scissors, Search, Send, Server, Settings, Share, Share 2, Shield, Shield Off, Shopping Bag, Shopping Cart, Shuffle, Sidebar, Skip Back, Skip Forward, Slack, Slash, Sliders, Smartphone, Smile, Speaker, Square, Star, Stop Circle, Sun, Sunrise, Sunset

**T-Z:**
Table, Tablet, Tag, Target, Terminal, Thermometer, Thumbs Down, Thumbs Up, Toggle Left, Toggle Right, Tool, Trash, Trash 2, Trello, Trending Down, Trending Up, Triangle, Truck, TV, Twitch, Twitter, Type, Umbrella, Underline, Unlock, Upload, Upload Cloud, User, User Check, User Minus, User Plus, User X, Users, Video, Video Off, Voicemail, Volume, Volume 1, Volume 2, Volume X, Watch, WiFi, WiFi Off, Wind, X, X Circle, X Octagon, X Square, YouTube, Zap, Zap Off, Zoom In, Zoom Out

### Icon Usage
- Stroke weight: 1-2px
- Color: Inherits from context (#1e1e1e default)
- Available in all component contexts
- Supports theming through CSS variables

---

## Implementation Notes for Uno Platform

### Recommended Approach

1. **Create ResourceDictionary for Design Tokens**
   - Define all color variables as `SolidColorBrush` resources
   - Define spacing values as `Double` or `Thickness` resources
   - Define typography styles as `Style` resources for `TextBlock`

2. **Component Hierarchy**
   - Create base styles for buttons, inputs, cards
   - Use ControlTemplates for complex components
   - Leverage VisualStateManager for state changes (hover, disabled, etc.)

3. **Typography**
   - Use Inter font family throughout
   - Create named styles: `BodyBaseTextBlockStyle`, `HeadingTextBlockStyle`, etc.
   - Ensure line-height values are properly converted

4. **Responsive Design**
   - Use `AdaptiveTriggers` for mobile/desktop breakpoints
   - Desktop: 1200px width
   - Mobile: 375px width

5. **Icons**
   - Consider using FontIcon with Segoe Fluent Icons
   - Or embed SVG icons as Path geometries
   - Create reusable icon resources

6. **Color Theming**
   - All colors should use ThemeResource markup
   - Support light/dark modes if needed
   - Maintain consistent contrast ratios

### Key Conversions

#### Tailwind → XAML
- `flex` → `StackPanel` with `Orientation`
- `gap-[X]` → `StackPanel.Spacing`
- `p-[X]` → `Padding`
- `rounded-[X]` → `CornerRadius`
- `border-[X]` → `BorderThickness` / `BorderBrush`
- `text-[X]` → `Foreground`
- `bg-[X]` → `Background`

#### Layout Strategy
- Use `Grid` for complex layouts
- Use `StackPanel` with `Spacing` for linear layouts
- Use `Border` for rounded corners and shadows
- Use `ThemeShadow` for elevation (Translation Z-axis)

### Asset Management
All image URLs are temporary (7-day expiration). Download and include in project:
- Save to `Assets/` folder
- Reference via `ms-appx:///Assets/[filename]`

---

## Summary Statistics

- **Total Components:** 40+
- **Total Icons:** 286
- **Total Example Pages:** 10
- **Color Tokens:** 30+
- **Spacing Tokens:** 10
- **Typography Styles:** 10+

---

## Next Steps

1. ✅ Design system extracted
2. ⬜ Create XAML ResourceDictionaries
3. ⬜ Implement core components (Button, Card, Input)
4. ⬜ Build example pages
5. ⬜ Test responsiveness
6. ⬜ Validate accessibility
7. ⬜ Document component usage

---

**Generated by:** Figma MCP Server + GitHub Copilot  
**Date:** November 13, 2025

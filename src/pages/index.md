---
title: Hydrogen - Light as air.
---
# <a name="getting-started"></a>Getting Started
## Practical for projects of any size.

[Hydrogen](https://github.com/pimbrouwers/hydrogen) is a lightweight modular CSS foundation designed for minimalists, with a powerful collection of components and utility classes. The aim of this project to allow for beautiful front-end's to be developed quickly.

You can starting working with [Hydrogen](https://github.com/pimbrouwers/hydrogen) in multiple ways. The option with least resistance is a `<link>` referencing the free unpkg CDN. 

### CDN

```html
<link rel="stylesheet" href="https://unpkg.com/hydrogen-css"/>
```

### NPM

```javascript
npm install hydrogen-css
```

# <a name="base"></a>Base
## A minimal reset to create cross-browser consistency.

[Hydrogen](https://github.com/pimbrouwers/hydrogen) includes a minimal css reset to reduce browser inconsistencies in things like default line heights, margins and font sizes of headings etc. 

Explicit font sizes for headings to ensure consistent rendering. For example, without explicit font sizes, the user agent stylesheet will apply differing sizes to headings within a `<section>`.

All sizing within [Hydrogen](https://github.com/pimbrouwers/hydrogen) is done using `rem`. All `rem` units are converted to base 16, so `1rem` is equal to `16px`.

# <a name="typography"></a>Typography
## `rem` based progressive sizing.

By default, all headings, paragraphs, and code use system fonts, using the most modern one available on a user's operating system. All font-sizes are based on `rem` units.  

### Headings
<div class="reset">
  <h1>H1 Heading</h1>
  <h2>H2 Heading</h2>
  <h3>H3 Heading</h3>
  <h4>H4 Heading</h4>
  <h5>H5 Heading</h5>
  <h6>H6 Heading</h6>
</div>

### Paragraph
<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>

### Lists
<ul>
  <li>Lorem ipsum</li>
  <li>Lorem ipsum</li>
  <li>Lorem ipsum</li>
</ul>

<ol>
  <li>Lorem ipsum</li>
  <li>Lorem ipsum</li>
  <li>Lorem ipsum</li>
</ol>

### Description List
<dl>
  <dt>Lorem</dt>
  <dd>Ipsum</dd>

  <dt>Lorem</dt>
  <dd>Ipsum</dd>
</dl>

# <a name="buttons"></a>Buttons
## A perfect base for beautiful buttons.

[Hydrogen](https://github.com/pimbrouwers/hydrogen) offers two styles of button, bordered and filled. The default `.h-btn` class is combined with `.h-btn-fill` to create a filled button. The styles are intended to serve as a base and can easily be overriden.

<button class="h-btn">Button</button>
<button class="h-btn" disabled>Disabled Button</button>
<br /><br />
<button class="h-btn h-btn-fill">Fill Button</button>
<button class="h-btn h-btn-fill" disabled>Disabled Fill Button</button>

```html
<button class="h-btn">Button</button>
<button class="h-btn" disabled>Disabled Button</button>

<button class="h-btn h-btn-fill">Fill Button</button>
<button class="h-btn h-btn-fill" disabled>Disabled Fill Button</button>
```

# <a name="tables"></a>Tables
## Elegant override for default table styles.

To override the default user agent table styles, simply append the `.h-tbl` class to the `<table>` element.

<table class="h-tbl">
  <thead>
    <tr>
      <th>#</th>
      <th>Header</th>
      <th>Header</th>
      <th>Header</th>
      <th>Header</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>1,001</td>
      <td>Lorem</td>
      <td>ipsum</td>
      <td>dolor</td>
      <td>sit</td>
    </tr>
    <tr>
      <td>1,002</td>
      <td>amet</td>
      <td>consectetur</td>
      <td>adipiscing</td>
      <td>elit</td>
    </tr>
    <tr>
      <td>1,003</td>
      <td>Integer</td>
      <td>nec</td>
      <td>odio</td>
      <td>Praesent</td>
    </tr>         
  </tbody>
</table>

```html
<table class="h-tbl">
  <thead>
    <tr>
      <th>#</th>
      <th>Header</th>
      <th>Header</th>
      <th>Header</th>
      <th>Header</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>1,001</td>
      <td>Lorem</td>
      <td>ipsum</td>
      <td>dolor</td>
      <td>sit</td>
    </tr>
    <tr>
      <td>1,002</td>
      <td>amet</td>
      <td>consectetur</td>
      <td>adipiscing</td>
      <td>elit</td>
    </tr>
    <tr>
      <td>1,003</td>
      <td>Integer</td>
      <td>nec</td>
      <td>odio</td>
      <td>Praesent</td>
    </tr>         
  </tbody>
</table>
```

# <a name="menus"></a>Menus
## Easily create user navigation components.

Foundational styles of both vertical and inline navigation components. By default the `.h-menu` class renders a vertical navigation component, to make inline simply append the `.h-menu-inline` modifier. 

Include the optional `.h-menu-heading` element to include a descriptive title. 

### Vertical Menu
<div class="h-menu">
  <span class="h-menu-heading">DEFAULT MENU</span>

  <ul class="h-menu-list">
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
  </ul>
</div>

```html
<div class="h-menu">
  <span class="h-menu-heading">DEFAULT MENU</span>

  <ul class="h-menu-list">
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
  </ul>
</div>
```

### Inline Menu
<div class="h-menu h-menu-inline">
  <span class="h-menu-heading">INLINE MENU</span>

  <ul class="h-menu-list">
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
  </ul>
</div>

```html
<div class="h-menu h-menu-inline">
  <span class="h-menu-heading">INLINE MENU</span>

  <ul class="h-menu-list">
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
    <li class="h-menu-item">
      <a href="#" class="h-menu-link">Link</a>
    </li>
  </ul>
</div>
```

# <a name="forms"></a>Forms
## Simple HTML forms.

By default the `.h-form` class renders an inline form, to create a stacked form simply append the `.h-form-stack` modifier. 

Form elements can be combined with [grid unit sizes](#grid-unit-sizes) to render fields of specific widths.

### Inline (default)

<form class="h-form">
  <fieldset>
    <legend>A compact inline form</legend> 

    <input type="email" placeholder="Email"> 

    <input type="password" placeholder="Password" required=""> 

    <input type="text" placeholder="Disabled" disabled> 

    <label for="state">State</label>
    <select name="state">
      <option>
        AL
      </option>
      <option>
        CA
      </option>
      <option>
        IL
      </option>
    </select> 

    <label for="remember">
      <input id="remember" type="checkbox"> Remember me
    </label> 

    <button class="h-btn h-btn-primary" type="submit">Sign in</button>
  </fieldset>
</form>

```html
<form class="h-form">
  <fieldset>
    <legend>A compact inline form</legend> 

    <input type="email" placeholder="Email"> 

    <input type="password" placeholder="Password" required=""> 

    <input type="text" placeholder="Disabled" disabled> 

    <label for="state">State</label>
    <select name="state">
      <option>
        AL
      </option>
      <option>
        CA
      </option>
      <option>
        IL
      </option>
    </select> 

    <label for="remember">
      <input id="remember" type="checkbox"> Remember me
    </label> 

    <button class="h-btn h-btn-primary" type="submit">Sign in</button>
  </fieldset>
</form>
```

### Stacked

<form class="h-form h-form-stack">
  <fieldset>
    <legend>A stacked form</legend>

    <input type="email" placeholder="Email">

    <input type="password" placeholder="Password" required="">

    <input type="text" placeholder="Disabled" disabled>

    <label for="state">State</label>
    <select name="state">
      <option>
        AL
      </option>
      <option>
        CA
      </option>
      <option>
        IL
      </option>
    </select>

    <label for="remember">
      <input id="remember" type="checkbox"> Remember me
    </label>

    <button class="h-btn h-btn-primary" type="submit">Sign in</button>
  </fieldset>
</form>

```html
<form class="h-form h-form-stack">
  <fieldset>
    <legend>A stacked form</legend>

    <input type="email" placeholder="Email">

    <input type="password" placeholder="Password" required="">

    <input type="text" placeholder="Disabled" disabled>

    <label for="state">State</label>
    <select name="state">
      <option>
        AL
      </option>
      <option>
        CA
      </option>
      <option>
        IL
      </option>
    </select>

    <label for="remember">
      <input id="remember" type="checkbox"> Remember me
    </label>

    <button class="h-btn h-btn-primary" type="submit">Sign in</button>
  </fieldset>
</form>
```

# <a name="grid"></a>Grid
## Foundation to build fully custom, responsive grids.

The built-in grid system provides the foundation for fully custom, responsive grids. Choose a width, and the rest is done for you. 

Grids blocks are designated using the `.h-g` class and grid units `.h-u`. To enable gutters (`1rem`) simply wrap the grid block in a grid container element using th `.h-c` class.

<div class="h-c">
  <div class="h-g">
    <div class="h-u example-main">
      <div class="pad background-blue color-gray">Main</div>
    </div> 
    <div class="h-u example-sidebar">
      <div class="pad background-blue color-gray">Sidebar</div>
    </div> 
  </div>
</div>

```html
<style> 
  @media screen and (min-width: 48em){ 
    .main { width: 75%; } 
    .sidebar { width: 25%; } 
  } 
</style> 

<div class="h-c">
  <div class="h-g"> 
    <div class="h-u main"> ... </div> 
    <div class="h-u sidebar"> ... </div> 
  </div>
</div>
```

# <a name="grid-unit-sizes"></a>Grid Unit Sizes
## A 12<sup>th</sup> scale responsive grid system.

[Hydrogen](https://github.com/pimbrouwers/hydrogen) ships with a mobile-first responsive grid system that can be used declaratively through CSS class names (i.e. `.h-u-6-12` represents a unit with 50% width). It's a robust and flexible grid that builds on top of the base grid system.

Grid units used without a media prefix (i.e. "-sm", "-md", "-lg", "-xl") are applied to all screen sizes. Grid units with a media prefixes, are applied to the specified width and above. Breakpoint definitions are outlined below.

| Prefix | Applies          | Class Name |
|--------|------------------|------------|
| None   | All screen sizes | `h-u-*`    |
| `sm`   | ≥ `30rem`        | `h-u-sm-*` |
| `md`   | ≥ `48rem`        | `h-u-md-*` |
| `lg`   | ≥ `64rem`        | `h-u-lg-*` |
| `xl`   | ≥ `80rem`        | `h-u-xl-*` |

### Responsive Grid Example

The example below leverages [Hydrogen](https://github.com/pimbrouwers/hydrogen)'s grid unit sizes to create a row with four columns. The columns stack on all screens, take up `width: 50%` on small screens, `width: 33.333%` on medium-sized screens, and `width: 25%` on large screens.

This is done by adding the `.h-u-12-12` class for all screens, `.h-u-sm-6-12` for small screens, `.h-u-md-4-12` for medium-sized screens and `.h-u-lg-3-12` for extra large screens. Resize the page to see the grid respond to the screen size.

<div class="h-c">
  <div class="h-g">
    <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">
      <div class="pad background-blue color-gray">
        <h4>Lorem Ipsum</h4>
        <p>Nunc interdum dui urna. Donec at lectus sed nisi tristique imperdiet.</p>
      </div>
    </div>
    <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">
      <div class="pad background-blue color-gray">
        <h4>Lorem Ipsum</h4>
        <p>Nunc interdum dui urna. Donec at lectus sed nisi tristique imperdiet.</p>
      </div>
    </div>
    <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">
      <div class="pad background-blue color-gray">
        <h4>Lorem Ipsum</h4>
        <p>Nunc interdum dui urna. Donec at lectus sed nisi tristique imperdiet.</p>
      </div>
    </div>
    <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">
      <div class="pad background-blue color-gray">
        <h4>Lorem Ipsum</h4>
        <p>Nunc interdum dui urna. Donec at lectus sed nisi tristique imperdiet.</p>
      </div>
    </div>
  </div>
</div>

```html
<div class="h-g">			
  <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">...</div>
  <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">...</div>
  <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">...</div>
  <div class="h-u-12-12 h-u-sm-6-12 h-u-md-4-12 h-u-lg-3-12">...</div>
</div>
```

# <a name="utilities"></a>Utilities
## Utility classes for common css tasks.

### Flex
- `.h-flex` (sets `  display: flex;`)
- `.h-flex-column` (sets `flex-direction: column;`)
- `.h-flex-row` (sets `flex-direction: row;`)
- `.h-flex-nowrap` (sets `flex-wrap: nowrap;`)
- `.h-flex-wrap` (sets `flex-wrap: wrap;`)
- `.h-flex-align-center` (sets `align-items: center;`)
- `.h-flex-align-end` (sets `align-items: flex-end;`)
- `.h-flex-align-start` (sets `align-items: flex-start;`)
- `.h-flex-align-self-center` (sets `align-self: center;`)
- `.h-flex-align-self-end` (sets `align-self: flex-end;`)
- `.h-flex-align-self-start` (sets `align-self: flex-start;`)
- `.h-flex-justify-center` (sets `justify-content: center;`)
- `.h-flex-justify-end` (sets `justify-content: flex-end;`)
- `.h-flex-justify-start` (sets `justify-content: flex-start;`)

### Float
- `.h-clear` (sets `clear: both`)
- `.h-clear-left` (sets `clear: left;`)
- `.h-clear-right` (sets `clear: right;`)
- `.h-left` (sets `float: left;`)
- `.h-right` (sets `float: right;`)

### Margin
- `.h-margin-top` (sets `margin-top: @base;`)
- `.h-margin-right` (sets `margin-right: @base;`)
- `.h-margin-bottom` (sets `margin-bottom: @base;`)
- `.h-margin-left` (sets `margin-left: @base;`)

### Padding
- `.h-padding-top` (sets `padding-top: @base;`)
- `.h-padding-right` (sets `padding-right: @base;`)
- `.h-padding-bottom` (sets `padding-bottom: @base;`)
- `.h-padding-left` (sets `margin-left: @base;`)

### Size
- `.h-full-height` (sets `min-height: 100vh;`)
- `.h-full-width` (sets `width: 100%;`)
- `.h-full` (sets `min-height: 100vh; width: 100%;`)

### Text
- `.h-text-center` (sets `text-align: center;`)
- `.h-text-left` (sets `text-align: left;`)
- `.h-text-right` (sets `text-align: right;`)

# <a name="customize-and-extend"></a>Customize & Extend
## Designed to be both customizable and extensible.

[Hydrogen](https://github.com/pimbrouwers/hydrogen) is broken up into a set of responsive modules, adopting [SMACSS](http://smacss.com/) as a convention for writing our CSS. For those who are new to [SMACSS](http://smacss.com/), you should give it a quick read, especially the section on module rules.

One of the conventions in [Hydrogen](https://github.com/pimbrouwers/hydrogen) is for every module to have a standard class name for common rules across a module, and then have additional class names for specific presentational rules for a specific sub-module. All classes start with a `h-` prefix to prevent collisions.

### Customize

To customize simply clone the source from [GitHub](https://github.com/pimbrouwers/hydrogen), navigate to the project route & run `npm install` and modify the contents of the `_variables.less` and/or `components/_variables.less` file(s). Once finished, run the build process by navigating to the project root and running `npm start`. 

# Components
## Common elements to help meet your deadlines.

### <a name="alerts"></a>Alerts
<div class="h-alert">I'm a test alert!</div>

<div class="h-alert">
  I'm a test alert with a close!
  <span class="h-alert-close">&times;</span>
</div>

```html
<div class="h-alert">I'm a test alert!</div>

<!-- With a close button -->
<div class="h-alert">
  I'm a test alert with a close!
  <span class="h-alert-close">&times;</span>
</div>
```

### <a name="badges"></a>Badges

<span class="h-badge">Badge 1</span>
<span class="h-badge h-badge-fill">Badge 2</span>

```html
<span class="h-badge">Badge 1</span>
<span class="h-badge h-badge-fill">Badge 2</span>
```

### <a name="breadcrumbs">Breadcrumbs

<div class="h-breadcrumbs">
  <a href="#" class="h-breadcrumbs-item">Home</a>
  <span class="h-breadcrumbs-spacer">/</span>
  <a href="#" class="h-breadcrumbs-item">Stories</a>
  <span class="h-breadcrumbs-spacer">/</span>
  <span class="h-breadcrumbs-item">A Great Tale</span>
</div>

```html
<div class="h-breadcrumbs">
  <a href="#" class="h-breadcrumbs-item">Home</a>
  <span class="h-breadcrumbs-spacer">/</span>
  <a href="#" class="h-breadcrumbs-item">Stories</a>
  <span class="h-breadcrumbs-spacer">/</span>
  <span class="h-breadcrumbs-item">A Great Tale</span>
</div>
```

### <a name="button-groups"></a>Button Groups

<div class="h-btn-group">
  <button class="h-btn">Button 1</button>
  <button class="h-btn">Button 2</button>
  <button class="h-btn">Button 3</button>
  <button class="h-btn">Button 4</button>
</div>

<div class="h-btn-group h-margin-top">
  <button class="h-btn h-btn-fill">Button 1</button>
  <button class="h-btn h-btn-fill">Button 2</button>
  <button class="h-btn h-btn-fill">Button 3</button>
  <button class="h-btn h-btn-fill">Button 4</button>
</div>

```html
<div class="h-btn-group">
  <button class="h-btn">Button 1</button>
  <button class="h-btn">Button 2</button>
  <button class="h-btn">Button 3</button>
  <button class="h-btn">Button 4</button>
</div>

<div class="h-btn-group">
  <button class="h-btn h-btn-fill">Button 1</button>
  <button class="h-btn h-btn-fill">Button 2</button>
  <button class="h-btn h-btn-fill">Button 3</button>
  <button class="h-btn h-btn-fill">Button 4</button>
</div>
```

### <a name="card"></a>Cards

<div class="h-card h-text-center">
  <div class="h-card-header">
    Header
  </div>
  <div class="h-card-body">
    I'm a test card!
  </div>
  <div class="h-card-footer">
    Footer
  </div>
</div>

```html
<div class="h-card h-text-center">
  <div class="h-card-header">
    Header
  </div>
  <div class="h-card-body">
    I'm a test card!
  </div>
  <div class="h-card-footer">
    Footer
  </div>
</div>
```

### Input Groups

<form action="" class="h-form h-form-stack">
  <label>Website</label>
  <div class="h-input-group">
    <span class="h-input-group-addon">http://</span>
    <input class="h-input-group-field" type="text" />
  </div>

  <label>Handle</label>
  <div class="h-input-group">
    <span class="h-input-group-addon">@</span>
    <input class="h-input-group-field" type="text" />
  </div>

  <label>Email</label>
  <div class="h-input-group">
    <input class="h-input-group-field" type="text" />
    <span class="h-input-group-addon">.com</span>
  </div>

  <label>Income</label>
  <div class="h-input-group">
    <span class="h-input-group-addon">USD$</span>
    <input class="h-input-group-field" type="text" />
    <span class="h-input-group-addon">.00</span>
  </div>

  <label>Ordered</label>
  <div class="h-input-group">
    <button class="h-input-group-addon">Up</button>
    <button class="h-input-group-addon">Down</button>
    <input class="h-input-group-field h-flex-grow" type="text" />
    <button class="h-input-group-addon">Delete</button>
  </div>

  <label>Two Inputs</label>
  <div class="h-input-group">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <input class="h-input-group-field h-flex-grow" type="text" placeholder="Name" />
  </div>

  <label>Three Inputs</label>
  <div class="h-input-group">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <input class="h-input-group-field h-flex-grow" type="text" placeholder="Name" />
    <input class="h-input-group-field" type="text" placeholder="Email" />
  </div>

  <label>Two Inputs Stack</label>
  <div class="h-input-group h-input-group-stack">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <input class="h-input-group-field" type="text" placeholder="Name" />
  </div>

  <label>Editor</label>
  <div class="h-input-group h-input-group-stack">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <textarea class="h-input-group-field" type="text" placeholder="Text"></textarea>
  </div>
</form>

```html
<form action="" class="h-form h-form-stack">
  <label>Website</label>
  <div class="h-input-group">
    <span class="h-input-group-addon">http://</span>
    <input class="h-input-group-field" type="text" />
  </div>

  <label>Handle</label>
  <div class="h-input-group">
    <span class="h-input-group-addon">@</span>
    <input class="h-input-group-field" type="text" />
  </div>

  <label>Email</label>
  <div class="h-input-group">
    <input class="h-input-group-field" type="text" />
    <span class="h-input-group-addon">.com</span>
  </div>

  <label>Income</label>
  <div class="h-input-group">
    <span class="h-input-group-addon">USD$</span>
    <input class="h-input-group-field" type="text" />
    <span class="h-input-group-addon">.00</span>
  </div>

  <label>Ordered</label>
  <div class="h-input-group">
    <button class="h-input-group-addon">Up</button>
    <button class="h-input-group-addon">Down</button>
    <input class="h-input-group-field h-flex-grow" type="text" />
    <button class="h-input-group-addon">Delete</button>
  </div>

  <label>Two Inputs</label>
  <div class="h-input-group">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <input class="h-input-group-field h-flex-grow" type="text" placeholder="Name" />
  </div>

  <label>Three Inputs</label>
  <div class="h-input-group">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <input class="h-input-group-field h-flex-grow" type="text" placeholder="Name" />
    <input class="h-input-group-field" type="text" placeholder="Email" />
  </div>

  <label>Two Inputs Stack</label>
  <div class="h-input-group h-input-group-stack">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <input class="h-input-group-field" type="text" placeholder="Name" />
  </div>

  <label>Editor</label>
  <div class="h-input-group h-input-group-stack">
    <input class="h-input-group-field" type="text" placeholder="Title" />
    <textarea class="h-input-group-field" type="text" placeholder="Text"></textarea>
  </div>
</form>
```

### <a name="pills"></a>Pills

<div>
  <button class="h-btn">
    Button w/ Pill
    <span class="h-pill h-right h-margin-left">3</span>
  </button>

  <button class="h-btn h-btn-fill">
    Button w/ Pill
    <span class="h-pill h-pill-inverted h-right h-margin-left">233</span>
  </button>

  <span class="h-badge">
    Badge w/ Pill
    <span class="h-pill h-right h-margin-left">1</span>
  </span>

  <span class="h-badge h-badge-fill">
    Badge w/ Pill
    <span class="h-pill h-pill-inverted h-right h-margin-left">122</span>
  </span>
</div>

```html
<button class="h-btn">
  Button w/ Pill
  <span class="h-pill h-right h-margin-left">3</span>
</button>

<button class="h-btn h-btn-fill">
  Button w/ Pill
  <span class="h-pill h-pill-inverted h-right h-margin-left">233</span>
</button>

<span class="h-badge">
  Badge w/ Pill
  <span class="h-pill h-right h-margin-left">1</span>
</span>

<span class="h-badge h-badge-fill">
  Badge w/ Pill
  <span class="h-pill h-pill-inverted h-right h-margin-left">122</span>
</span>
```

### <a name="switches"></a>Switches

<label class="h-switch">
  <input type="checkbox">
  <span class="h-switch-rail">
    <span class="h-switch-toggle"></span>
  </span>
</label>

```html
<label class="h-switch">
  <input type="checkbox">
  <span class="h-switch-rail">
    <span class="h-switch-toggle"></span>
  </span>
</label>
```

### <a name="titles"></a>Titles
<h1 class="h-title">
  Title
  <span class="h-subtitle">Subtitle</span>
</h1>

```html
<h1 class="h-title">
  Title
  <span class="h-subtitle">Subtitle</span>
</h1>
```
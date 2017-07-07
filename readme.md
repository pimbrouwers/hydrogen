## Install

Hydrogen is a modern CSS foundation. I avoid the use of the word "framework", because it implies bias. Hydrogen is entriely _unbiased_ and offering up only a starting point with the **intention** of being overriden. It is small enough to be justifiable on small projects, and customizable enough to use on large applications.

To get started simply download the [base CSS file](https://raw.githubusercontent.com/pimbrouwers/HydrogenCSS/master/clr.min.css) (~2.3KB / 937 bytes gzipped) and the optional [grid units file](https://github.com/pimbrouwers/HydrogenCSS/blob/master/h-grid-units.min.css).


## Typography

``` html
<!-- Headings -->
<h1>...</h1>
<h2>...</h2>
<h3>...</h3>
<h4>...</h4>

<!-- Paragraph -->
<p>...</p>
```

## Lists
```html
<!-- Unordered -->
<ul class="h-list">
    <li>Item 1</li>
    <li>Item 2</li>
    <li>Item 3</li>
</ul> 

<!-- Ordered --> 
<ol class="h-list"> 
    <li>Item 1</li> 
    <li>Item 2</li>
    <li>Item 3</li>
</ol> 
```

## Menus
```html
<!-- Vertical -->
<ul class="h-menu">
    <li><span>Heading</span></li>
    <li>
        <a href="#">Item 1</a>
    </li>
    <li>
        <a href="#">Item 2</a>
    </li>
    <li>
        <a href="#">Item 3</a>
    </li>
</ul>

<!-- Horizontal -->
<ul class="h-menu h-menu-inline">
    <li><span>Heading</span></li>
    <li>
        <a href="#">Item 1</a>
    </li>
    <li>
        <a href="#">Item 2</a>
    </li>
    <li>
        <a href="#">Item 3</a>
    </li>
</ul>
```

## Tables
```html
<table class="h-tbl">
    <thead> 
        ... 
    </thead> 
    <tbody> 
        ... 
    </tbody> 
</table>
```


## Buttons
```html
<button class="h-btn">A Button</button> 
<button class="h-btn" disabled>A Disabled Button</button> 
```


## Forms
```html
<!-- Inline --> 
<form class="h-form"> 
    ... 
</form> 

<!-- Stacked --> 
<form class="h-form h-form-stack"> 
    ... 
</form>
```


## Grid

By default, Hydrogen's grid provides you with the foundation to build fully custom, responsive grids. Enabling you to truly program for the responsive medium that is the web.

```html
<style> 
    @media screen and (min-width: 50em){ 
        .content { width: 75%; } 
        .sidebar { width: 25%; } 
    } 
</style> 

<div class="h-g"> 
    <div class="h-u content"> ... </div> 
    <div class="h-u sidebar"> ... </div> 
</div>
```


## Grid Units

To make development faster, Hydrogen ships with a separate grid-units file. That offers preset grid units on the 12th scale, with triggers at the follow breakpoints:

``` html
<div class="h-g"> 
    <div class="h-u h-u-sm-8-12"> ... </div> 
    <div class="h-u h-u-sm-4-12"> ... </div> 
</div> 
```

## Customize

Hydrogen is very easy to customize. Simply clone the source from https://github.com/pimbrouwers/HydrogenCSS, navigate to the project route & run `npm install` and modify the contents of the `_variables.less` file. Once finished, run the build process by navigating to the project root and running `npm run build`. 

Below are the options available:

```less
@sm-break: 30em;
@md-break: 48em;
@lg-break: 64em;
@xl-break: 76.5em;

@base: .75em;
@base-color: #ddd;

@grid-units: 12;
@grid-gutter: @base * 2;

@tbl-border-color: @base-color;
@tbl-gutter: @base;

@btn-color: @base-color;
@btn-padding: @base;

@form-legend-border: @base-color;
@form-legend-spacing: @base;
@form-stack-spacing: @base;

@input-padding: @base;
@input-border: @base-color;
```

Built with ♥ by [Pim Brouwers](https://github.com/pimbrouwers) in Toronto, ON. Licensed under [MIT](https://github.com/pimbrouwers/HydrogenCSS/blob/master/LICENSE).

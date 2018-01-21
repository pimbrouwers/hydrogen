# Hydrogen CSS

Hydrogen is a modern CSS foundation designed for minimalists with deadlines and inspired by my ♥ for [PureCSS](https://purecss.io/). 

Hydrogen is entriely _unbiased_ and offering up only a starting point with the **intention** of being overriden. It is small enough to be justifiable on small projects, and customizable enough to use on large applications.

> Documentation site coming soon!

## Getting Started

- `npm install --save hydrogen-css`
- Or, using unpkg `<link rel="stylesheet" href="https://unpkg.com/hydrogen-css/dist/hydrogen.min.css"/>` 
	- For the grid-utils dependency: `<link rel="stylesheet" href="https://unpkg.com/hydrogen-css/dist/hydrogen.grid-utils.min.css"/>`
	- For the components dependency: `<link rel="stylesheet" href="https://unpkg.com/hydrogen-css/dist/hydrogen.components.min.css"/>`

## Reset

Hydrogen includes a minimal css reset (inspired by Eric Meyer's reset.css) to reduce browser inconsistencies in things like default line heights, margins and font sizes of headings etc. 

Explicit font sizes for headings to ensure consistent rendering. For example, without explicit font sizes, the user agent stylesheet will apply differing sizes to headings within a `<section>...</section>`.

## Typography

```html
<!-- Headings -->
<h1>...</h1>
<h2>...</h2>
<h3>...</h3>
<h4>...</h4>

<!-- Paragraph -->
<p>...</p>

<!-- Lists -->
<ul>
	<li>item</li>
	<li>item</li>
	<li>item</li>
</ul>

<ol>
	<li>item</li>
	<li>item</li>
	<li>item</li>
</ol>
```

## Menus
```html
<!-- Vertical -->
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

<!-- Inline -->
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

## Tables
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


## Buttons
```html
<button class="h-btn">Button</button>
<button class="h-btn" disabled>Disabled Button</button>

<button class="h-btn h-btn-fill">Fill Button</button>
<button class="h-btn h-btn-fill" disabled>Fill Button</button>

<a class="h-btn" href="#">&lt;a&gt;..&lt;/a&gt; Button</a>
<a class="h-btn h-btn-fill" href="#">&lt;a&gt;..&lt;/a&gt; Fill Button</a>
```


## Forms
```html
<!-- Inline --> 
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

<!-- Stacked --> 
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


## Grid

By default, Hydrogen's grid provides you with the foundation to build fully custom, responsive grids.

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

To make development faster, Hydrogen ships with grid-units, base on a **12th scale**. Scale is customizable via `@grid-units` variable (see below). 

Grid units used without a media prefix (i.e. "-sm", "-md", "-lg", "-xl") are applied to all screen sizes. Breakpoint definitions are outlined below.

``` html
<!-- All screens -->
<div class="h-g">			
	<div class="h-u h-u-1-12">h-u-1-12</div>
	<div class="h-u h-u-11-12">h-u-11-12</div>

	<div class="h-u h-u-2-12">h-u-2-12</div>
	<div class="h-u h-u-10-12">h-u-10-12</div>

	<div class="h-u h-u-3-12">h-u-3-12</div>
	<div class="h-u h-u-9-12">h-u-9-12</div>

	<div class="h-u h-u-4-12">h-u-4-12</div>
	<div class="h-u h-u-8-12">h-u-8-12</div>

	<div class="h-u h-u-5-12">h-u-5-12</div>
	<div class="h-u h-u-7-12">h-u-7-12</div>

	<div class="h-u h-u-6-12">h-u-6-12</div>
	<div class="h-u h-u-6-12">h-u-6-12</div>

	<div class="h-u h-u-12-12">h-u-12-12</div>
</div>

<!-- Screen > 30em -->
<div class="h-g">
	<div class="h-u h-u-sm-1-12">h-u-sm-1-12</div>
	<div class="h-u h-u-sm-11-12">h-u-sm-11-12</div>

	<div class="h-u h-u-sm-2-12">h-u-sm-2-12</div>
	<div class="h-u h-u-sm-10-12">h-u-sm-10-12</div>

	<div class="h-u h-u-sm-3-12">h-u-sm-3-12</div>
	<div class="h-u h-u-sm-9-12">h-u-sm-9-12</div>

	<div class="h-u h-u-sm-4-12">h-u-sm-4-12</div>
	<div class="h-u h-u-sm-8-12">h-u-sm-8-12</div>

	<div class="h-u h-u-sm-5-12">h-u-sm-5-12</div>
	<div class="h-u h-u-sm-7-12">h-u-sm-7-12</div>

	<div class="h-u h-u-sm-6-12">h-u-sm-6-12</div>
	<div class="h-u h-u-sm-6-12">h-u-sm-6-12</div>

	<div class="h-u h-u-sm-12-12">h-u-sm-12-12</div>
</div>

<!-- Screen > 48em -->
<div class="h-g">
	<div class="h-u h-u-md-1-12">h-u-md-1-12</div>
	<div class="h-u h-u-md-11-12">h-u-md-11-12</div>

	<div class="h-u h-u-md-2-12">h-u-md-2-12</div>
	<div class="h-u h-u-md-10-12">h-u-md-10-12</div>

	<div class="h-u h-u-md-3-12">h-u-md-3-12</div>
	<div class="h-u h-u-md-9-12">h-u-md-9-12</div>

	<div class="h-u h-u-md-4-12">h-u-md-4-12</div>
	<div class="h-u h-u-md-8-12">h-u-md-8-12</div>

	<div class="h-u h-u-md-5-12">h-u-md-5-12</div>
	<div class="h-u h-u-md-7-12">h-u-md-7-12</div>

	<div class="h-u h-u-md-6-12">h-u-md-6-12</div>
	<div class="h-u h-u-md-6-12">h-u-md-6-12</div>

	<div class="h-u h-u-md-12-12">h-u-md-12-12</div>
</div>

<!-- Screen > 64em -->
<div class="h-g">
	<div class="h-u h-u-lg-1-12">h-u-lg-1-12</div>
	<div class="h-u h-u-lg-11-12">h-u-lg-11-12</div>

	<div class="h-u h-u-lg-2-12">h-u-lg-2-12</div>
	<div class="h-u h-u-lg-10-12">h-u-lg-10-12</div>

	<div class="h-u h-u-lg-3-12">h-u-lg-3-12</div>
	<div class="h-u h-u-lg-9-12">h-u-lg-9-12</div>

	<div class="h-u h-u-lg-4-12">h-u-lg-4-12</div>
	<div class="h-u h-u-lg-8-12">h-u-lg-8-12</div>

	<div class="h-u h-u-lg-5-12">h-u-lg-5-12</div>
	<div class="h-u h-u-lg-7-12">h-u-lg-7-12</div>

	<div class="h-u h-u-lg-6-12">h-u-lg-6-12</div>
	<div class="h-u h-u-lg-6-12">h-u-lg-6-12</div>

	<div class="h-u h-u-lg-12-12">h-u-lg-12-12</div>
</div>

<!-- Screen > 80em -->
<div class="h-g">
	<div class="h-u h-u-xl-1-12">h-u-xl-1-12</div>
	<div class="h-u h-u-xl-11-12">h-u-xl-11-12</div>

	<div class="h-u h-u-xl-2-12">h-u-xl-2-12</div>
	<div class="h-u h-u-xl-10-12">h-u-xl-10-12</div>

	<div class="h-u h-u-xl-3-12">h-u-xl-3-12</div>
	<div class="h-u h-u-xl-9-12">h-u-xl-9-12</div>

	<div class="h-u h-u-xl-4-12">h-u-xl-4-12</div>
	<div class="h-u h-u-xl-8-12">h-u-xl-8-12</div>

	<div class="h-u h-u-xl-5-12">h-u-xl-5-12</div>
	<div class="h-u h-u-xl-7-12">h-u-xl-7-12</div>

	<div class="h-u h-u-xl-6-12">h-u-xl-6-12</div>
	<div class="h-u h-u-xl-6-12">h-u-xl-6-12</div>

	<div class="h-u h-u-xl-12-12">h-u-xl-12-12</div>
</div>
```

## Utils

General set of useful utility classes for common css tasks.

### Text Alignment

- `.h-text-center`
- `.h-text-left`
- `.h-text-right`

### Size

- `.h-full-height` (sets height: 100vh)
- `.h-full-width` (sets width: 100%)
- `.h-full` (apply both `.h-full-height` and `.h-full-width`)

### Flexbox

- `.h-flex` (sets display: flex)
- `.h-flex-column` (sets flex-direction: column)
- `.h-flex-row` (sets flex-direction: row)
- `.h-flex-nowrap` (sets flex-wrap: nowrap)
- `.h-flex-wrap` (sets flex-wrap: wrap)
- `.h-flex-align-center` (sets align-items: center)
- `.h-flex-align-end` (sets align-items: flex-end)
- `.h-flex-align-start` (sets align-items: flex-start)
- `.h-flex-align-self-center` (sets align-self: center)
- `.h-flex-align-self-end` (sets align-self: flex-end)
- `.h-flex-align-self-start` (sets align-self: flex-start)
- `.h-flex-justify-center` (sets justify-content: center)
- `.h-flex-justify-end` (sets justify-content: flex-end)
- `.h-flex-justify-start` (sets justify-content: flex-start)

## Customize

Hydrogen is very easy to customize. Simply clone the source from https://github.com/pimbrouwers/hydrogen, navigate to the project route & run `npm install` and modify the contents of the `_variables.less` file. Once finished, run the build process by navigating to the project root and running `npm start`. 

Below are the options available:

```less
//base
@base: .75em;

//  Breakpoints
@sm-break: 30rem;
@md-break: 48rem;
@lg-break: 64rem;
@xl-break: 80rem;

//  Tints
@raw: rgb(255, 255, 255);
@rare: rgb(204, 204, 204);
@medium-rare: rgb(153, 153, 153);
@medium: rgb(102, 102, 102);
@medium-well: rgb(51, 51, 51);
@well-done: rgb(0,0,0);

//  Buttons
@btn-color: @rare;
@btn-padding: @base;

//  Forms
@form-legend-border: @rare;
@form-legend-spacing: @base;
@form-label-margin: @base;
@form-stack-spacing: @base;
@input-padding: @base;
@input-border: @rare;

//  Grid
@grid-prefix: ~"";
@grid-prefix-sm: ~"-sm";
@grid-prefix-md: ~"-md";
@grid-prefix-lg: ~"-lg";
@grid-prefix-xl: ~"-xl";
@grid-units: 12;

//  Lists
@list-margin-left: @base * 2;

//  Menus
@menu-color: @medium-well;
@menu-item-padding: @btn-padding;
@menu-link-hover: @rare;

//  Tables
@tbl-border-color: @rare;
@tbl-gutter: @base;
```

Built with ♥ by [Pim Brouwers](https://github.com/pimbrouwers) in Toronto, ON. Licensed under [MIT](https://github.com/pimbrouwers/hydrogen/blob/master/LICENSE).

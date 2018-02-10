const
  Ditto = require('ditt0'),
  DittoMarkdown = require('ditt0-markdown'),
  DittoHbs = require('ditt0-hbs');

Ditto()
  .source('./pages')
  .destination('../')
  .use(new DittoMarkdown())
  .use(new DittoHbs({
    partials: './templates/partials',
    templates: './templates'
  }))
  .build();
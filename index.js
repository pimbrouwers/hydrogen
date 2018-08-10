const
  Ditto = require('ditt0'),
  DittoMarkdown = require('ditt0-markdown'),
  DittoHbs = require('ditt0-hbs');

Ditto()
  .source('./src/pages')
  .destination('./dist')
  .use(new DittoMarkdown())
  .use(new DittoHbs({
    partials: './src/templates/partials',
    templates: './src/templates'
  }))
  .build();
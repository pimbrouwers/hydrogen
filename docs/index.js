const
    Ditto = require("ditt0"),
    DittoJson = require("ditt0-json"),
    DittoHbs = require("ditt0-hbs");

Ditto(__dirname)
    .clobber(false)
    .metadata({
        title: "Hydrogen - Light as air."
    })
    .source("./src/pages")
    .destination("./build")
    .use(new DittoJson())
    .use(new DittoHbs({
        defaultTemplate: "index",
        partials: "./src/templates/partials",
        templates: "./src/templates"
    }))
    .build(function(err) {
        if (err) throw err;
    });
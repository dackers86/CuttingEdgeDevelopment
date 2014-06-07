
define('text!scalejs.slider-bxslider/bxslider.html',[],function () { return '<div id="sj_bxslider_template">\r\n    <ul class="bxslider"  data-class="bxslider-items">\r\n        <li data-class="bxslider-item-content"></li>\r\n    </ul>\r\n</div>';});

/// <reference path="../scripts/_references.js" />
/*global console,define*/
define('scalejs.slider-bxslider/bxsliderBindings',[],function () {
    
    return {
        'bxslider-items': function () {
            return {
                foreach: this.items
            };
        },
        'bxslider-item-content': function(ctx) {
            return {
              template: {
                  name: ctx.$parent.itemTemplate,
                  data: ctx.$data
              }  
            };
        }
    };
});


/*global define*/
define('scalejs.slider-bxslider/bxslider',[
    'scalejs!core',
    'text!./bxslider.html',
    './bxsliderBindings',
    'knockout',
    'jQuery',
    'scalejs.mvvm'
], function (
    core,
    bxsliderTemplate,
    bxsliderBindings,
    ko,
    $
) {
    var registerBindings = core.mvvm.registerBindings,
        registerTemplates = core.mvvm.registerTemplates,
        unwrap = ko.utils.unwrapObservable;

    function wrapValueAccessor(valueAccessor, element) {
        return function () {
            var slider = valueAccessor();

            //TODO: apply bxSlider after last child element is rendered
            function afterRender() {
                if (unwrap(slider.items).length > 0) {
                    $(element).children().bxSlider(slider.options);
                }
            }
            return {
                name: 'sj_bxslider_template',
                data: slider,
                afterRender: afterRender
            };
        };
    }

    function init(        element,        valueAccessor,        allBindingsAccessor,        viewModel,        bindingContext    ) {
        return { 'controlsDescendantBindings': true };
    }

    function update(
        element,
        valueAccessor,
        allBindingsAccessor,
        viewModel,
        bindingContext
    ) {
        return ko.bindingHandlers.template.update(
            element,
            wrapValueAccessor(valueAccessor, element),
            allBindingsAccessor,
            viewModel,
            bindingContext
        );
    }

    registerTemplates(bxsliderTemplate);
    registerBindings(bxsliderBindings);

    return {
        init: init,
        update: update
    };
});


/*global define*/
define('scalejs.slider-bxslider',[
    'knockout',
    './scalejs.slider-bxslider/bxslider',
    'jQuery',
    'bxslider'
], function (
    ko,
    bxslider
) {
    
    // bxslider imposed the constraint that all items
    // must be List elements (ul/li).
    // the way we handle this is by dealing with it as divs
    // and letting the extension build the list.
    // so, you need a div to specify the binding for bxslider,
    // and a div for the template of your items which must
    // be passed to 'itemTemplate'
    ko.bindingHandlers.bxslider = bxslider;
});


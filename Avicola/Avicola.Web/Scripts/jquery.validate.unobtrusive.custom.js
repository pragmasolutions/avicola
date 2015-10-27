(function ($) {

    $.validator.addMethod("unique", function (value, element, params) {
        var prefix = params;
        var selector = jQuery.validator.format("[name!='{0}'][name$='{1}'][data-val-unique-uniquesufix='{1}']", element.name, prefix);
        var matches = new Array();
        $(selector, $(element).closest('form')).each(function (index, item) {
            if (value == $(item).val()) {
                matches.push(item);
            }
        });

        return matches.length == 0;
    });
    $.validator.unobtrusive.adapters.addSingleVal("unique", "uniquesufix");
    

    $.validator.unobtrusive.adapters.add(
        'notequalto', ['other'], function (options) {
            options.rules['notEqualTo'] = '#' + options.params.other;
            if (options.message) {
                options.messages['notEqualTo'] = options.message;
            }
        });

    $.validator.addMethod('notEqualTo', function (value, element, param) {
        return this.optional(element) || value != $(param).val();
    }, '');
    

    $.validator.unobtrusive.adapters.add(
        'notequaltovalue', ['value'], function (options) {
            options.rules['notEqualToValue'] = '#' + options.params.value;
            if (options.message) {
                options.messages['notEqualToValue'] = options.message;
            }
        });

    $.validator.addMethod('notEqualToValue', function (value, element, param) {
        return this.optional(element) || value != $(param).val();
    }, '');

    // definition for the isdateafter validation rule
    $.validator.addMethod('isdateafter', function (value, element, params) {
        value = Globalize.parseDate(value);
        var otherDate = Globalize.parseDate($(params.compareTo).val());
        
        if (!value || !otherDate)
            return true;

        return value > otherDate || (value.getTime() === otherDate.getTime() && params.allowEqualDates);
    });

    $.validator.unobtrusive.adapters.add('isdateafter', ['propertytested', 'allowequaldates'], function (options) {
        options.rules['isdateafter'] = {
            'allowEqualDates': options.params['allowequaldates'],
            'compareTo': '#' + options.params['propertytested']
        };
        options.messages['isdateafter'] = options.message;
    });

})(jQuery)

var nifSpain = function() {
    var that = {};

    that.correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";

    that.getLetter = function(numbers) {
         return that.correspondencia[numbers % 23];
    };

    that.check = function(nif) {

        var valid_letter;
        if (nif.length != 9)
            return false;
        else {
            valid_letter = that.getLetter(nif.substring(0, 8));
            return valid_letter == nif[8];
        }

    };

    return that;
};
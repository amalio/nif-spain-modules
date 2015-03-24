var nifSpain = function() {
    var that = {};



    that.getLetter = function(numbers) {
        var correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
        return correspondencia[numbers % 23];
    };

    that.check = function(nif) {

        var valid_letter;
        if (nif.length != 9)
            return false;
        else {
            return that.getLetter(nif.substring(0, 8)) == nif[8];
        }

    };

    return that;
};
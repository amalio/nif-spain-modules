var nifSpain = function() {
    var that = {};
    that.correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
    that.getLetter = function(numbers) {
         return that.correspondencia[numbers % 23];
    };

    return that;
};
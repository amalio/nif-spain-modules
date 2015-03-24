__author__ = 'amalio'


class NifSpain:

    correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE"

    def get_letter(self, nif_numbers):
        if type(nif_numbers) is not int:
            nif_numbers = int(nif_numbers)
        return self.correspondencia[nif_numbers % 23]

    def check(self, nif):
        if type(nif) is not str:
            return False
        numbers = int(nif[:-1])
        letter = nif[-1]
        valid_letter = self.get_letter(numbers)
        if valid_letter == letter:
            return True
        else:
            return False

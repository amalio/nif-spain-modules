__author__ = 'amalio'


class NifSpain:

    correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE"

    def get_letter(self, nif_string):
        return self.correspondencia[nif_string % 23]

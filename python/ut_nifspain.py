__author__ = 'amalio'

import unittest
import nifspain


class NifSpainTestCase(unittest.TestCase):
    def test_giveme_correct_letter(self):
        nif = nifspain.NifSpain()
        self.assertEqual("B", nif.get_letter("12332358"))
        


if __name__ == '__main__':
    unittest.main()

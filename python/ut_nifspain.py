__author__ = 'amalio'

import unittest
import nifspain


class NifSpainTestCase(unittest.TestCase):

    def setUp(self):
        self.nif = nifspain.NifSpain()

    def tearDown(self):
        self.nif = None

    def test_giveme_correct_letter(self):
        self.assertEqual("B", self.nif.get_letter(12332358))
        self.assertEqual("L", self.nif.get_letter(12311919))


if __name__ == '__main__':
    unittest.main()

__author__ = 'amalio'

import unittest
import nifspain


class NifSpainTestCase(unittest.TestCase):

    def setUp(self):
        self.nif = nifspain.NifSpain()

    def tearDown(self):
        self.nif = None

    def test_get_letter(self):
        self.assertEqual("B", self.nif.get_letter(12332358))
        self.assertEqual("L", self.nif.get_letter(12311919))
        self.assertEqual("B", self.nif.get_letter("12332358"))

    def test_check(self):
        self.assertTrue(self.nif.check("12332358B"))
        self.assertTrue(self.nif.check("12311919L"))
        self.assertFalse(self.nif.check("12332357B"))
        self.assertFalse(self.nif.check("12"))
        self.assertFalse(self.nif.check(12))



if __name__ == '__main__':
    unittest.main()

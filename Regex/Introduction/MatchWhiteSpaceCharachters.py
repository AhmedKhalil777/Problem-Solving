import re
import sys
import unittest


def matchWhiteSpaceVsNonWhiteSpace(test_string):
    regex_pattern = r"\S{2}\s\S{2}\s\S{2}"
    return re.match(regex_pattern, test_string ) is not None



class MatchingWhiteSpaceVsNonWhiteSpace(unittest.TestCase):

    def testCase_matchWhiteSpaceVsNonWhiteSpace_GivenMultiSetOfInputd_ShouldReturnExpected(var):
        var.assertEqual(matchWhiteSpaceVsNonWhiteSpace("12 11 15"), True, "Should return true")

if __name__ == "__main__":
    unittest.main()
import re
import sys
import unittest


def matchAnythingButaNewLine(test_string):
    regex_pattern = r"^([^\n]{3}\.){3}[^\n]{3}$"
    return re.match(regex_pattern, test_string ) is not None



class MatchingAnythingButaNewlineTests(unittest.TestCase):

    def testCase_matchAnythingButaNewLine_GivenMultiSetOfInputd_ShouldReturnExpected(var):
        var.assertEqual(matchAnythingButaNewLine("123.456.abc.def"), True, "Should return true")
        var.assertEqual(matchAnythingButaNewLine("1123.456.abc.def"), False, "Should return false")

if __name__ == "__main__":
    unittest.main()
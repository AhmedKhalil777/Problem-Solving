import re
import sys
import unittest


def matchDigitVsNonDigits(test_string):
    regex_pattern = r"(\d{2})\D(\d{2})\D(\d{4})"
    return re.match(regex_pattern, test_string ) is not None



class MatchDigitVsNonDigits(unittest.TestCase):

    def testCase_matchDigitVsNonDigits_GivenMultiSetOfInputd_ShouldReturnExpected(var):
        var.assertEqual(matchDigitVsNonDigits("06-11-2015"), True, "Should return true")
        var.assertEqual(matchDigitVsNonDigits("10a10.2015452254"), True, "Should return true")

if __name__ == "__main__":
    unittest.main()
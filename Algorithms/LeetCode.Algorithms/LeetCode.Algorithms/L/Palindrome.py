class Palindrome(object):
    def longestPalindrome(self, s):
        n = len(s) # Length of the input

        if n == 1:
            return s

        def expandOutwards(start, end):

            i = start
            k = end

            if s[i] != s[k]:
                return ""

            while(i-1 >= 0 and k+1 < n and s[i-1] == s[k+1]): 
                i-=1
                k+=1

            return s[i:k+1]

        pal1 = ""
        pal2 = ""
        longPal = ""

        for i in range(0, n-1):

            pal1 = expandOutwards(i, i)
            pal2 = expandOutwards(i, i+1)

            # Conditional assignment statement
            temp = pal1 if len(pal1) > len(pal2) else pal2

            if len(temp) > len(longPal):
                longPal = temp
        
        return longPal

#include<stdio.h>

class Solution {
public:
    bool isPalindrome(int x) {
        //negative numbers are never palindromic
        if(x < 0)
            return false;
        if(x < 10)
            return true;
        // reverse number and compare to original
        unsigned long int r = x;
        unsigned long int n = 0;
        do {
            
            n = n * 10 + r % 10;
            r /= 10;
            
        }while(r != 0);
        return n == x;
    }
};

int main(void)
{
   Solution s;
 printf("%d\n", s.isPalindrome(121));
 printf("%d\n", s.isPalindrome(-121));
 printf("%d\n", s.isPalindrome(10));
 printf("%d\n", s.isPalindrome(-101));
 printf("%d\n", s.isPalindrome(1234567899));
 printf("%d\n", s.isPalindrome(123454321));
 return 0;
}
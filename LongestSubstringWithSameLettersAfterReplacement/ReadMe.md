# Longest Substring with Same Letters After Replacement

## Problem Domain: 

Given a string with lowercase letters only, if you are allowed to replace no more than ‘k’ letters with any letter, find the length of the longest substring having the same letters after replacement.

## Sliding Windows Algorithm:

1. Create a sliding window with windowEnd (rightChar) and windowStart (leftChar) and put all elements into a HashMap (Dictionary), keeping track of character and its frequency.
2. Use Math.Max to return the character that has the greatest frequency.
3. k is the maximum number of letters we are allowed to replace, so window minus maxLetterFrequency must be > k. If it is not, we need to shrink our window. 
4. Find our official max length (that is within the scope of k) and return its length.

## Big O: 

O(n) for time (need to go through the whole input string only once)
O(26) because there are no more than 26 letters in the English alphabet that will be stored in the HashMap (Dictionary) along with their frequency.

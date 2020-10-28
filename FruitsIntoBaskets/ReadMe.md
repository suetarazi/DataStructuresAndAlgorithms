# Fruits Into Baskets

## Problem Domain: 

Given an array of characters where each character represents a fruit tree, you are given two baskets and your goal is to put maximum number of fruits in each basket. The only restriction is that each basket can have only one type of fruit.

You can start with any tree, but once you have started you can’t skip a tree. You will pick one fruit from each tree until you cannot, i.e., you will stop when you have to pick from a third fruit type.

Write a function to return the maximum number of fruits in both the baskets.

## Algorithm: Sliding Window

### Find the length of the longest subarray with no more than two distinct characters.

1. Create a sliding window with windowStart and windowEnd as your pointers.
2. try to extend the range [windowStart, windowEnd]
3. create a Dictionary (HashMap) to keep track of <char>character, <int>frequency of character
3. shrink the sliding window until we are left with 2 distinct characters in the dictionary (i.e. if the frequency of a character reaches 0, remove it from the Dictionary or HashMap)
4. return the maximum length (i.e. windowEnd-windowStart +1)

## BigO
Time: O(n)
Space O(1)

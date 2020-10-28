# Pair with Target Sum

## Problem Domain: 

Given an array of sorted numbers and a target sum, find a pair in the array whose sum is equal to the given target.

Write a function to return the indices of the two numbers (i.e. the pair) such that they add up to the given target.

## Two Pointer Algorithm:

1. Start with a SORTED array. Have one pointer pointing to the beginning of the array and one pointing to the end. 
2. With each step, we see if the sum of the two numbers add up to our target number. If so, return their indices.
3. If not, 
4. * if the sum is too small, increment the left pointer
   * if the sum is too big, decrement the right pointer
5. Return the indices of the two numbers that add up to our sum or {-1, -1} if not found.

## Big O:

This approach is more efficient as using two pointers allows us to only make one pass through the array.
Therefore, our Time Complexity is O(n).

Our Space Complexity is O(1) since no additional space is used. 
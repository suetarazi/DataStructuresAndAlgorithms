# Smallest Subarray with a Given Sum

## Sliding Window

## Problem statement: 

Given an array of positive numbers and a positive number ‘S’, find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. Return 0, if no such subarray exists.

### Algorithm:

1. Add up elements from teh beginning of the array until their sum becomes greater than or equal to S.
2. These elements become our initial window. We are asked to find the smallest such window, so this is the smallest window so far.
3. We now keep adding one element to the sliding window.
4. We also try and shrink the window from the beginning. We keep shrinking the window until the sum is < S. 
5. Two steps are necessary for each window shrink:
   * Check if the current window length is the smallest so far, and if so, remember its length.
   * Subtract the first element of the window from the running sum to shrink the sliding window.

## Big O: 

### Time Complexity:

O(n). Outer loop runs for all elements and inner while loop processes each element only once.

### Space Complexity: 

O(1)
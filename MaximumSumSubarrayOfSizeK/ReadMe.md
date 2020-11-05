# Maximum Sum Subarray of Size K

## Problem Domain:
Given an array of positive numbers and a positive number ‘k’, find the maximum sum of any contiguous subarray of size ‘k’.

## Sliding Window Algorithm: 
1. To calculate the sum of a contiguous subarray we can utilize the sum of the previous subarray. Treat each subarray as a Sliding Window of size ‘k’. To calculate the sum of the next subarray, slide the window ahead by one element.
2. * Subtract the outgoing element (leftmost element)
   * Add the new incoming element (rightmost element)
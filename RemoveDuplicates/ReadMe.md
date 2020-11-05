# Remove Duplicates

## Problem Domain: 

Given an array of sorted numbers, remove all duplicates from it. You should not use any extra space; after removing the duplicates in-place return the length of the subarray that has no duplicate in it.

## Two Pointer Algorithm:

1. Begin with a SORTED array. We need to 'shift' elements left whenever we encounter duplicates. We can do this easily in place with two pointers: one to iterate through the array and one to basically 'count' the number of non-duplicate values.
2. Iterate through the array and check:
* if we find a non-duplicate number, we move it next to the last non-duplicate number we have seen
* Then we simply return the count of nextNonduplicate, since this is the length of our 'new' array

## Big O:
Time complexity is O(n) since we traverse the array once only

Space complexity is O(1) since we 'shift' the array in place

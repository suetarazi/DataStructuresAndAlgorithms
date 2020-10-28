# Longest Substring with K Distinct Characters

## Problem Domain: 

Given a string, find the length of the longest substring in it with no more than K distinct characters.

## Sliding Window

### Algorithm:

1. Insert characters from the beginning of the string until we have 'K' distinct characters in a HashMap (Dictionary in C#).
2. This is our initial window and we need to remember its length as the longest window so far.
3. Slide the window ahead one character.
4. Now, try and shrink the window from the starting point: 
* If the count of distinct characters in the HashMap (or dictionary) is larger than K, we need to shrink the window until we have no more than K distinct characters.
* As we shrink the window, we need to decrement the frequency of the outgoing character and remove it from the HashMap or Dictionary if its frequency becomes 0
5. At the end of each step, we need to check if the current window length is the longest so far and if so, remember its length.
6. Return max window length    

## Big O:

### Time:

O(n + n) -> O(n)
Outer for loop runs for all characters and inner while loop processes each character only once

### Space: 
O(k) since we have to store a maximum of k+1 characters in the HashMap or Dictionary
  
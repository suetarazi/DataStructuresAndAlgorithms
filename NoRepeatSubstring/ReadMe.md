# No Repeat Substring

## Problem Domain: 

Given a string, find the length of the longest substring which has no repeating characters.

## Sliding Windows Algorithm: 

1. Use the sliding window strategy and a HashMap (or Dictionary) to remember the last index of each character we have processed.
2. If we get a repeating character, we shrink our sliding window (move windowStart) to make sure we only have distinct characters in the sliding window.
3. Return the width of the sliding window.

## Big O:

O(n) for time since we are only making one pass through the string.

O(K) for space, where K is the number of distinct characters (note: K is always <= N).


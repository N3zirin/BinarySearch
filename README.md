Binary search is an efficient algorithm for finding a target value within a sorted array.
The logic involves repeatedly dividing the search interval in half. Initially, the search interval is the entire array.
If the target value is less than the middle element, the search continues in the left half;
- if greater, it continues in the right half.
This process repeats until the target value is found or the interval is empty, which implies the target is not present in the array.

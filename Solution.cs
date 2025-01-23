public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums); // Sort the array for use with the triple-pointer technique
        int closestSum = nums[0] + nums[1] + nums[2]; // Initialize the closest sum to the first 3 numbers
        for (int indexPointer = 0; indexPointer < nums.Length - 2; indexPointer++) // Loop the index pointer through the array
        {
            if (indexPointer > 0 && nums[indexPointer] == nums[indexPointer - 1]) continue; // Skip duplicates
            int leftPointer = indexPointer + 1; // Initializing left pointer to next element (after i)
            int rightPointer = nums.Length - 1;
            while (leftPointer < rightPointer)
            {//get the sum of the current number + left pointer number + right pointer number
                int sum = nums[indexPointer] + nums[leftPointer] + nums[rightPointer];//then check the absolute difference
                if (sum == target) { return sum; }//if the sum is equal to the target, return the sum
                if (Math.Abs(target - sum) < Math.Abs(target - closestSum))//this sum and closest
                {//and set the closest sum to be this sum if it is closer
                    closestSum = sum;
                }
                if (sum < target)//remember our array is sorted
                {//so if the sum is less than the target,
                    leftPointer++;//we want to move our left pointer up
                }//to look for a higher number and sum
                else//if the sum if greater than the target,
                {//move the right pointer down
                    rightPointer--;//to look for a lower number and sum
                }
            }
        }//done
        return closestSum;
    }
}

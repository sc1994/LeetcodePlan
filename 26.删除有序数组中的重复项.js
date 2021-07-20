/*
 * @lc app=leetcode.cn id=26 lang=javascript
 *
 * [26] 删除有序数组中的重复项
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function (nums) {
    if (!nums || !nums.length) return 0;

    var lastIndex = 0;
    for (let index = 1; index < nums.length; index++) {
        if (nums[lastIndex] == nums[index]) {
            nums.splice(index, 1);
            index--;
            continue;
        }
        lastIndex++;
    }
    return nums.length;
};
// @lc code=end


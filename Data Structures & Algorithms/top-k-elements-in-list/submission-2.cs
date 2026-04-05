public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!map.ContainsKey(num))
                map[num] = 1;
            else
                map[num]++;
        }

        var result = map
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();

        return result;
    }
}
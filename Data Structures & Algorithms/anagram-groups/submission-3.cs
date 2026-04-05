public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> sortedDictionary = new Dictionary<string,List<string>>();
        foreach(string word in strs)
        {
         char[] sortarr = word.ToCharArray();
         Array.Sort(sortarr);
         string key = new string(sortarr);
         if(!sortedDictionary.ContainsKey(key))
         {
            sortedDictionary[key] = new List<string>();
         }
         sortedDictionary[key].Add(word);
        }
        return sortedDictionary.Values.ToList();
    }
}

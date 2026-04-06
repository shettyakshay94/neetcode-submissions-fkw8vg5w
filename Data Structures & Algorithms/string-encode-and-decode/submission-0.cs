
public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strs)
        {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            // Find '#'
            while (s[j] != '#')
            {
                j++;
            }

            // Extract length
            int length = int.Parse(s.Substring(i, j - i));

            // Move to start of word
            j++;

            // Extract word
            string word = s.Substring(j, length);
            result.Add(word);

            // Move to next segment
            i = j + length;
        }

        return result;
    }
}
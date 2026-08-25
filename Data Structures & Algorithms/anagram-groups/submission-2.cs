public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            string key = new string(s.OrderBy(c => c).ToArray());

            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }
            groups[key].Add(s);
        }
        return groups.Values.ToList();
    }
}

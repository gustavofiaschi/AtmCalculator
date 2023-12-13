using System.Text;

public static class Atm {
    private static int[] cartridges = [10, 50, 100];
    internal static int[] payouts = [100];//[30, 50, 60, 80, 140, 230, 370, 610, 980];

    public static string GetCombinations(int option) {  
        StringBuilder sb = new StringBuilder();
        if (option > 0) {
            var payout = payouts[option - 1];            
            foreach (string s in GetCombinations(cartridges, payout, "")) {
                sb.AppendLine(s);
            }
            sb.AppendLine(Environment.NewLine);
            return sb.ToString();
        }       
        return string.Empty;
    }
    private static IEnumerable<string> GetCombinations(int[] cartridges, int sum, string values) {
        for (int i = 0; i < cartridges.Length; i++) {
            int left = sum - cartridges[i];
            string vals = cartridges[i] + "," + values;
            if (left == 0) {
                yield return vals;
            } 
            else {
                if (sum > 0) {
                    foreach (string s in GetCombinations(cartridges, left, vals)) {
                        yield return s;
                    }
                }
            }
        }
    }
}
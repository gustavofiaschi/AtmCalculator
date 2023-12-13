public static class Atm {
    private static int[] cartridges = [10, 50, 100];
    public static int[] payouts = [100];//[30, 50, 60, 80, 140, 230, 370, 610, 980];

    public static void GetCombinations(int option) {  
        if (option > 0) {
            var payout = payouts[option - 1];    
            Console.WriteLine("Payout: " + payout);
            foreach (string s in GetCombinations(cartridges, payout, "")) {
                Console.WriteLine(s);
            }
            Console.WriteLine(Environment.NewLine);
        }       
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
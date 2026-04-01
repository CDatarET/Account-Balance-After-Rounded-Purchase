public class Solution {
    public int AccountBalanceAfterPurchase(int purchaseAmount) {
        return(100 - ((purchaseAmount + 10 / 2) / 10) * 10);
    }
}

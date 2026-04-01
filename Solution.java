class Solution {
    public int accountBalanceAfterPurchase(int purchaseAmount) {
        return(100 - ((purchaseAmount + 10 / 2) / 10) * 10);
    }
}

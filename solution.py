class Solution:
    def accountBalanceAfterPurchase(self, purchaseAmount):
        return 100 - ((purchaseAmount + 10 // 2) // 10) * 10

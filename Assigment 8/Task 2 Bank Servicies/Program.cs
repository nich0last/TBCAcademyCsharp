using BankServices;

BankAccount account1 = new BankAccount("1121", "Davit", new Currency(3000, "USD"));

//deposit
Currency depositAmount = new Currency(6000, "USD");
account1.Deposit(depositAmount);


//Withdraw
Currency withdrayAmount = new Currency(1000, "USD");
account1.Withdraw(withdrayAmount);

//BalanceCheck
account1.BalanceCheck();

//TransferFunds
BankAccount account2 = new BankAccount("586985", "Nicholas", new Currency(1000, "USD"));

Currency transferAmount = new Currency(300, "USD");
account1.TransferFunds(account2, transferAmount);
using System;

class BankAccount
{
    private string AccountNumber;
    private string OwnerName;
    private int Balance = 0;

    public BankAccount(string accountNumber, string ownerName)
    {
        this.AccountNumber = accountNumber;
        this.OwnerName = ownerName;
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)    Console.WriteLine("입금 금액은 0보다 커야 합니다.");
        else
        {
            Balance += amount;
            Console.WriteLine($"{amount}원 입금 완료. 잔액: {Balance}");
        }
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance) Console.WriteLine("잔액이 부족합니다.");
        else
        {
            Balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액: {Balance}");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {AccountNumber} ({OwnerName}) - 잔액: {Balance}원");
    }
}
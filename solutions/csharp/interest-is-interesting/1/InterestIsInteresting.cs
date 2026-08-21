static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        if (balance >= 0 && balance < 1000)
        {
            return 0.5f;
        }
        if (balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return ((decimal)InterestRate(balance) / 100)*balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
        if (balance >= targetBalance)
        {
            return year;
        }

        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            year++;
        }
        return year;
    }
}

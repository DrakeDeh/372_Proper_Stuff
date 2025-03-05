using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBack : CreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }
    public int GetCreditLimit()
    {
        return 15000;
    }
    public int GetAnnualCharge()
    {
        return 500;
    }
}

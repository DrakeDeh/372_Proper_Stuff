using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platium : CreditCard
{
    public string GetCardType()
    {
        return "Platinum Plus";
    }
    public int GetCreditLimit()
    {
        return 25000;
    }
    public int GetAnnualCharge()
    {
        return 2000;
    }
}

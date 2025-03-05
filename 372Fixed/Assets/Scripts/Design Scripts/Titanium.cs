using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titanium : CreditCard
{
    public string GetCardType()
    {
        return "Titanium";
    }
    public int GetCreditLimit()
    {
        return 25000;
    }
    public int GetAnnualCharge()
    {
        return 1500;
    }
}

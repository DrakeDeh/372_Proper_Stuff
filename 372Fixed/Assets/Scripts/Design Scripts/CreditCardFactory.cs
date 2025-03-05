using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditCardFactory : MonoBehaviour
{
    public static CreditCard GetCreditCard(string cardType)
    {
        CreditCard cardDetails = null;
        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platium();
        }
        return cardDetails;
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramEX : MonoBehaviour
{
    static void Main(string[] args)
    {
        CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platium");
        if (cardDetails != null)
        {
            Console.WriteLine("CardType : " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
        Console.ReadLine();
    }
}


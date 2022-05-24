module TypeComposition

type PaycheckNum = int
type CreditCardNum = string

type CreditCardType = Visa | Mastercard // OR
type CreditCardInfo = CreditCardType * CreditCardNum // AND

type PaymentMethod =
| Money // OR
| Paycheck of PaycheckNum // OR
| CreditCard of CreditCardInfo // OR

type CurrencyValue = decimal
type Currency = EUR | USD

type Payment = {
CurrencyValue : CurrencyValue
Currency : Currency
Method : PaymentMethod
}
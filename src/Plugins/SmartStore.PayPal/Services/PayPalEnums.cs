﻿
namespace SmartStore.PayPal.Services
{
	public enum PayPalPaymentInstructionItem
	{
		Reference = 0,
		BankRoutingNumber,
		Bank,
		Bic,
		Iban,
		AccountHolder,
		AccountNumber,
		Amount,
		PaymentDueDate,
		Details
	}

	public enum PayPalWebhookValidation
	{
		None = 0,
		Simple
	}
}
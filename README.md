# Invoice Project - ASP.NET MVC


## Description

The Invoice Project is an ASP.NET MVC web application designed to manage and generate invoices for small businesses. It provides a user-friendly interface for creating, viewing, and managing invoices, as well as tracking payments.

## Table of Contents

- [Installation](#installation)
- [Features](#features)
- [Usage](#usage)
- [Configuration](#configuration)
- [Database Setup](#database-setup)
- [Contact](#contact)

## Installation

To run the Invoice Project, follow these steps:

1. Clone the repository: 'git clone https://github.com/GaneshShid/InvoiceProject.git'
2. Open the solution in Visual Studio.
3. Build the solution to restore NuGet packages.
4. Press F5 to start the application.

## Features

- Create and manage customer profiles.
- Generate and preview detailed invoices with itemized billing.
- Track invoice statuses (paid, pending, overdue).
- Record payments and update invoice statuses accordingly.
- Export invoices to PDF or Excel format.

## Usage

1. **Home Page:** The home page displays an overview of recent invoices and their statuses.

2. **Invoices:** Navigate to the "Invoices" section to create and manage invoices. Click on "New Invoice" to start creating a new invoice, and then add items and set payment details.

3. **Customers:** Use the "Customers" section to manage customer profiles. Add new customers and view their invoice history.

4. **Payments:** The "Payments" section allows you to record payments received for each invoice. Mark invoices as paid, and the status will be automatically updated.


## Configuration

To use the Invoice Project, you need to set up the following configurations:

- Connection String: Update the connection string in `Web.config` to point to your SQL Server instance.

## Database Setup

1. Open the Package Manager Console in Visual Studio ('Tools > NuGet Package Manager > Package Manager Console').
2. Create the following tables.

tbl_customers
	customer_id(PK)
	invoice_id (fk)
	customer_name
	email_address
	mobile_number
	city

tbl_products
	product_id(PK)
	product_name
	purchase_price
	selling_price
	tax
	stock_quantity

tbl_invoice_details
	invoice_id(PK)
	invoice_date
	customer_id(FK)
	total_amount
	

tblinvoice_products
	payment_id(PK)
	invoice_id(FK)
	product_id(FK)
	quantity

tblinvoice_payments
	payment_id(PK)
	invoice_id(FK)
	payment_date
	payment_amount
	payment_mode
	description




If you have any questions or suggestions, feel free to reach out:

- Email: shidganesh0297@gmail.com

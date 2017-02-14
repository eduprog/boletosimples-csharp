﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoSimplesApiClient.UnitTests.Json
{
    public static class JsonConstants
    {
        public const string BankBilletAccount = @"{'bank_contract_slug':'sicoob-02', 'next_our_number':'1','agency_number': '4327','agency_digit': '3','account_number': '3666','account_digit': '8',
                                                       'extra1':'1234567','extra1_digit':'222','extra2':'1234567','extra2_digit':'222','extra3':'30 digits','beneficiary_name':'boleto simples cobranças ltda.',
                                                       'beneficiary_cnpj_cpf':'05.813.794/0001-26','beneficiary_address':'av. presidente vargas, 633 sala 1716. rio de janeiro - rj', 'name':'bancoob/sicoob 02 - cc 00003666-8',
                                                       'status':'', 'homologated_at':'2017-01-31 00:00:00', 'next_remittance_number':'1', 'configuration':'Any Configuration', 'bank_contract':{ 'bank':{'code':'sicoob',
                                                       'name':'bancoob/sicoob','number':'756'},'slug':'sicoob-02', 'code':'02','sufix':'02','variation':null,'name':'1/02 - simples sem registro'}}";

        public const string BankBillet = @"{'amount': '1.345,56', 'expire_at': '2030-01-31 00:00:00','description': 'Any Desc','customer_person_name': 'Test Billet', 'customer_cnpj_cpf': '45082419480','customer_zipcode': 12345678,
                                            'customer_email': 'anyemmail@gmail.com','customer_address': 'Any Street','customer_city_name': 'Rio de Janeiro','customer_state':'RJ','customer_neighborhood':'Glória',
                                            'customer_address_number': '100','customer_address_complement': 'Sl 1001','customer_phone_number': '21999999999','meta':'{ pedido: 10 }', 'status': 'Possible State', 
                                            'paid_at': '2030-01-31 00:00:00','paid_amount': '10.00', 'shorten_url': 'http://test', 'url': 'http://test', 'carne_url': 'http://test', 'formats': '','created_via_api': true,
                                            'fine_for_delay': 1.0,'late_payment_interest': 2.0,'guarantor_name': 'Name','guarantor_cnpj_cpf':'450.824.194-80','payment_place': 'Local','instructions': 'Instruções para o Caixa',
                                            'document_date':'2030-01-31 00:00:00','document_type': '','document_number': 99999999,'document_amount': '1.345,56','acceptance':'N','remittance_id': 999,'notes': 'Anotações','paid_bank':'Banco de Pagamento',
                                            'paid_agency': 'Agência de Pagamento'}";
    }
}
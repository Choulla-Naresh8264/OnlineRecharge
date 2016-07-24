﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineRecharge.Models.Helpers
{
    public class VoucherDetailsModel
    {
        public string ImageURL { get; set; }
        public string OperatorCode { get; set; }
        public decimal Amount { get; set; }
    }

    public class TopupTransferResponseDetailsModel
    {
        public string Response { get; set; }


        public string ResponseDescription { get; set; }


        public string PaymentID { get; set; }

        public string PaymentRef { get; set; }

        public DateTime Date { get; set; }
        public string ImageURL { get; set; }
        public string OperatorName { get; set; }
        public string  Amount { get; set; }
    }

   
    public class RechargeAPICustomResponseModels
    {
    }
}
﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayRollCorep.Models
{
    public class Salary
    {
        [Required(ErrorMessage = "Mời bạn nhập mức lương đóng bảo hiểm")]
        [Range(0, 999999999, ErrorMessage = "Số tiền không được là số âm ")]
        [BindRequired]
        public decimal premiumSalary { get; set; }

        [Required( ErrorMessage = "Mời bạn chọn vùng: ")]
        public decimal area { get; set; }

        [Required( ErrorMessage = "Mời bạn nhập Lương: ")]
        [Range(0, 999999999, ErrorMessage = "Số tiền phải lớn hơn 0")]
        public decimal salary { get; set; }

        [Required( ErrorMessage = "Mời bạn nhập số người phụ thuộc: ")]
        [Range(0, 999, ErrorMessage = "Số người phụ thuộc ít nhất là 0")]
        public int numberOfDependents { get; set; }

        // 10.5% bảo hiểm 
        public decimal? premium { get; set; }

        //BHXH - BHYT - BHTN
        public decimal socialInsurance { get; set; }
        public decimal healthInsurance { get; set; }
        public decimal unemploymentInsurance { get; set; }

        // thu nhập trước thuế (sau khi trừ đi 10.5% bảo hiểm)
        public decimal incomeBeforeTax { get; set; }

        //thu nhập chịu thuế
        public decimal incomeTaxes { get; set; }
        //thuế thu nhập cá nhân
        public decimal personalIncomeTax { get; set; }

        public decimal finalSalary { get; set; }
    }
}

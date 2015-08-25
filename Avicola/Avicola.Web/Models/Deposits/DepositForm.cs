using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;
using Resources;

namespace Avicola.Web.Models
{
    public class DepositForm : IMapFrom<Deposit>
    {
        [HiddenInput]
        public Guid Id { get; set; }
        [Required]
        [Remote("IsNameAvailable", "Deposit", ErrorMessage = "Ya existe un depósito con ese nombre", AdditionalFields = "Id")]
        public string Name { get; set; }

        public Deposit ToDeposit()
        {
            var deposit = Mapper.Map<DepositForm, Deposit>(this);
            return deposit;
        }

        public static DepositForm FromDeposit(Deposit driver)
        {
            var form = Mapper.Map<Deposit, DepositForm>(driver);
            return form;
        }
    }
}

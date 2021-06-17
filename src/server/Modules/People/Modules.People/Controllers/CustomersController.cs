﻿using FluentPOS.Modules.People.Core.Features.Customers.Commands;
using FluentPOS.Modules.People.Core.Features.Customers.Queries;
using FluentPOS.Shared.DTOs.People.Customers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FluentPOS.Modules.People.Controllers
{
    internal class CustomersController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginatedCustomerFilter filter)
        {
            var brands = await Mediator.Send(new GetAllPagedCustomersQuery(filter.PageNumber, filter.PageSize, filter.SearchString));
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, bool bypassCache)
        {
            var brand = await Mediator.Send(new GetCustomerByIdQuery(id, bypassCache));
            return Ok(brand);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(RegisterCustomerCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new RemoveCustomerCommand(id)));
        }
    }
}
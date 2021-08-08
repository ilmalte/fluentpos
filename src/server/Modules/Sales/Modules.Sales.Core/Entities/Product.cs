// <copyright file="Product.cs" company="Fluentpos">
// --------------------------------------------------------------------------------------------------
// Copyright (c) Fluentpos. All rights reserved.
// The core team: Mukesh Murugan (iammukeshm), Chhin Sras (chhinsras), Nikolay Chebotov (unchase).
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------
// </copyright>

using System;

namespace FluentPOS.Modules.Sales.Core.Entities
{
    public class Product
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; private set; }

    }
}
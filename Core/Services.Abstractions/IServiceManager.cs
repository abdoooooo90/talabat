﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
	public interface IServiceManager
	{
		public IProductService ProductService { get; }
		public IBasketService BasketService { get; }
		public IAthenticationService AthenticationService { get; }
		public IOrderService OrderService { get; }
		public IPaymentService PaymentService { get; }
		public ICachService CachService { get; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement
{
	class ClientDecorator : Populate
	{
		public ClientDecorator(Decorator decorator) : base(decorator)
		{

		}
	}
}

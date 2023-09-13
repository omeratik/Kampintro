using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	 class ProductManager
	{
		//encapsulation
		public void Add(Product product) //101 referans adresi
		{
            Console.WriteLine(product.ProductName + " eklendi.");
        }

		public void Update(Product prooduct)
		{
            Console.WriteLine(prooduct.ProductName + " güncellendi.");
        }	

		
		
		 
		}

	}
}


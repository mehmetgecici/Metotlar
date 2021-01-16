using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{
		public void add(Urun urun)
		{	
			Console.WriteLine(urun.Name+" Sepete Eklendi");
		}

		public void add_2(string urunAdı,string aciklama,double fiyat ,int stokAdedi)
		{	
			Console.WriteLine(urunAdı+" Sepete Eklendi");
		}
	}
}

using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun u1 = new Urun();
			u1.Name = "Elma";
			u1.Price = 2;
			u1.info = "Amasya elması";
			u1.Id = 1;

			Urun u2 = new Urun();
			u2.Name = "Karpuz";
			u2.Price = 80;
			u2.info = "Diyarbakır karpuzu";
			u2.Id = 2;

			Urun[] urunler = new Urun [] { u1, u2 };

			foreach (Urun item in urunler)
			{
				Console.WriteLine(item.Id+".Ürün adı : "+item.Name+ " Ürün Fiyatı :"+item.Price+" Ürün Açıklamsı :"+item.info);
			}

			Console.WriteLine("----------Metodlar-----------");
			SepetManager sp1 = new SepetManager();
			sp1.add(u1);
			sp1.add(u2);
		}
	}
}

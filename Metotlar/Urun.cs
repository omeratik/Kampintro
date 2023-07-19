using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
	class Urun
	{
        //Id veri ayırt edicidir.
        //aşağıdakilerin her biri bir özelliktir Property - özellik
        //kapsülleme ile özellikleri tek class altında topluyoruz
        public int Id { get; set; }
		public string Adi { get; set; }
        public double Fiyatı { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
        //prop tab tab
    }
}

 
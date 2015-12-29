using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Models;
using QueryDataBD.VIS;


namespace Services.VIS
{
    public class VisDemos
    {
        public List<CatCountry> GetDataCountry()
        {
            Demo demo=new Demo();
            List<CatCountry> data = demo.SelectData();
            return data;
        }

    }
}

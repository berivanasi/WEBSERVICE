using System;

namespace CONSOLERetAtt
{
    class Program
    {
        /* 
         * ATTIRIBUTESLAR VE REFLECTIONSLAR GENELDE BERABER KULLANILIRLAR
         * RUN TİME ESNASINDA CLASS ENUM METHOD GİBİ YAPILARLA İLGİLİ BİLGİ VEREN 
         * VE KONTROL ETMEMİZİ SAĞLAYAN YAPILARDIR 
         ----------------------------
         * AŞAĞIDAKİ ÖRNEĞİMİZDE PERSON İSMİNDEKİ SINIFIMIZA TANIMLADIĞIMIZ PROPERTİLERİN HEPSİNE
         * BİR DEĞER GİRİLMESİNİ, OLUŞTURDUĞUMUZ ATTİRİBUTES SAYESİNDE ZORUNLU HALE GETİRDİK
         * CONTROL SINIFIMIZDAKİ CHECK METODUMUZLADA BU KONTROL İŞLEMİNİ SAĞLADIK
         * FOREACH VE İFLERLE DOLULUK DURUMUNA BAKIP BOLL BİR DEĞER DÖNNDÜRDÜK...
         
         
         */ 
        static void Main(string[] args)
        {
            person p1 = new person()
            {
                Name="Mehmet", Age=34
            };
            Console.WriteLine(Control.check(p1));
            Console.ReadLine();

        }
    }
    class person
    {      [Zorunlu]
        public string Name;
        [Zorunlu]
        public string ID;
        [Zorunlu]
        public int Age;
    }
    public class ZorunluAttribute : Attribute { }

    public static class Control
    {
        public static bool check(person ins)
        {
            Type type = ins.GetType();
            foreach(var item in type.GetFields())
            {
                object[] atrributes = item.GetCustomAttributes(typeof(ZorunluAttribute), true);
                if(atrributes.Length !=0)
                {
                    object value = item.GetValue(ins);
                    if(value==null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

using System;

namespace ConsolDelegate
{
    class Program
    {
        /* Delegateler bir nevi metod pointerlarıdır
         -Yani onları yönetirler.
          -Delegete tipinde bir nesne türetip rahatlıkla işlemler yapabilmemizi sağlarlar
        -------------    ------------------ ------------------- -------------------------     --------
           -Aşağıdaki örnekte çevre ve alan hesabı yapan metodlarımı ana metodum içerisinde deleeteden
          -nesne turetip parametre geçirerek kullandım...
          -Ayrıca Delegetın parametresi içindeki değişkenlerinde aşağıdakilerle aynı olma zorunluluğu yoktur.
          
         */
        delegate double Dikdotgen(double x, double y);
        static void Main(string[] args)
        {
            Dikdotgen test = new Dikdotgen(alan);
            Console.WriteLine(test(3,8));
            Console.ReadLine();
        }
        static double cevre (double a , double b)
        {
            return 2 * (a + b);
        }
        static double alan(double a ,double b)
        {
             return a* b;
    }
}

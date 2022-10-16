using System;

namespace Oop3
{
    public class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine(value: "İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
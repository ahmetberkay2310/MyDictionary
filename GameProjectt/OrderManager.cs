using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class OrderManager : ICompanyService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void New(Gamer gamer)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}

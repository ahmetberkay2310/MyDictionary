using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    interface ICompanyService
    {
        void New(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}

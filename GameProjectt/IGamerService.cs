﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
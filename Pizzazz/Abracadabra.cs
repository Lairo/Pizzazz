﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzazz
{
    internal class Abracadabra
    {
        public int Vavavoom;

        public bool Lala(int floq)
        {
            if(floq < Vavavoom)
            {
                Vavavoom += floq;
                return true;
            }
            return false;
        }
    }
}

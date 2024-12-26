﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    internal class Ucaksavar:Cisim
    {
        public Ucaksavar(int panelGenisligi, Size hareketAlaniBoyutlari): base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi / 2;
            HareketMesafesi = Width;
        }
    }
}

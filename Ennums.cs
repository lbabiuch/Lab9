﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    [Flags]
    public enum PrzedzialWiekowy
    {
        Dzieci = 1,
        Mlodziez = 2,
        Dorosli = 4,
        Starsi = 8
    }
    [Flags]
    public enum Zainteresowania
    {
        Elektronika,
        Motoryzacja,
        Gaming,
        Ekonomia
    }
}

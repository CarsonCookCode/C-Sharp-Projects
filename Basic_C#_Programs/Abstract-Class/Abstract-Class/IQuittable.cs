﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    interface IQuittable
    {
        bool Hired { get; set; }

        void Quit();
    }
}

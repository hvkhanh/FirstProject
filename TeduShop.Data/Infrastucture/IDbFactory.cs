﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastucture
{
    public interface IDbFactory:IDisposable
    {
        TeduShopDbContext Init();
    }
}

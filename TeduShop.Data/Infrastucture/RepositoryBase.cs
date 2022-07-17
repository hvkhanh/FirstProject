using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastucture
{
    public abstract class RepositoryBase<T> where T:class
    { 
        //#region Properties
        private TeduShopDbContext dataContext;
        //private readonly IDBSet<T> dbSet;
    }
}

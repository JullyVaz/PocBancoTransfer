﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocBancoAPI.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task SaveChangesAsync();
        Task RollBackAsync();
    }
}

﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}

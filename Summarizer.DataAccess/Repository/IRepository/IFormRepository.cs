﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarizer.DataAccess.Repository.IRepository
{
    public interface IFormRepository : IRepository<Form>
    {
        void Update(Form obj);
    }
}

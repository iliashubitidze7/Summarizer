using Summarizer.DataAccess.Data;
using Summarizer.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarizer.DataAccess.Repository
{
    public class FormRepository : Repository<Form> , IFormRepository
    {
        private ApplicationDbContext db;

        public FormRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Form obj)
        {
            db.Forms.Update(obj);
        }
    }
}

using Summarizer.DataAccess.Data;
using Summarizer.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarizer.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext db;
        public IFormRepository summarizer {  get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
            summarizer = new FormRepository(db);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

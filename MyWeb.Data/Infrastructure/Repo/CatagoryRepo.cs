using MyApp.Data;
using MyWeb.Data.Infrastructure.Ireposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Data.Infrastructure.Repo
{
    public class CatagoryRepo : Repo<Catagory>, ICatagoryRepo

    {
        private DataContext _context;

        public CatagoryRepo(DataContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Catagory catagory)
        {
            _context.Catagories.Update(catagory);
        }
    }
}

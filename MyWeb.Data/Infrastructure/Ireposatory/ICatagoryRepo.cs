using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Data.Infrastructure.Ireposatory
{
    internal interface ICatagoryRepo : IReposatory<Catagory>
    {
        void Update(Catagory catagory);


    }
}

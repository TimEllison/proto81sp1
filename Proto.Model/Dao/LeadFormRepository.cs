using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.Model.Dao
{
    public class LeadFormRepository
    {
        public void AddLead(Lead leadToAdd)
        {
            using (var context = new LeadFormsEntities())
            {
                leadToAdd.LeadTypeId = 1;
                context.Leads.Add(leadToAdd);
                context.SaveChanges();
            }
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaBsReconciliationDetailManager: IBaBsReconciliationDetailService
    {
        private readonly IBaBsReconciliationDal _babsReconciliationDal;

        public BaBsReconciliationDetailManager(IBaBsReconciliationDal babsReconciliationDal)
        {
            _babsReconciliationDal = babsReconciliationDal;
        }
    }
}

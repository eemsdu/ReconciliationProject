using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CurrencyAccountManager:ICurrencyAccountService
    {
        private readonly ICurrencyAccountDal _currencyDal;

        public CurrencyAccountManager(ICurrencyAccountDal currencyDal)
        {
            _currencyDal = currencyDal;
        }
    }
}

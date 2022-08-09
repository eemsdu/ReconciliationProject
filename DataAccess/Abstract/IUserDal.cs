using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user,int companyId);
        //kullanıcı yetkilendirme verdik ve hangi şirkete ait yetkili olduğu söylendi  
        //kullanıcının yetkilerini bir yerde tutup çekmemiz lazım 


    }
}

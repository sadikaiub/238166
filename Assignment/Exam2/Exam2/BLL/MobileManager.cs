using Exam2.Model;
using Exam2.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.BLL
{
    public class MobileManager
    {
        MobileRepository _mobileRepository = new MobileRepository();
        

        public int Insert(Mobile mobile)
        {
            return _mobileRepository.Insert( mobile);
        }
        public DataTable SearchMobile(Mobile mobile)
        {
            return _mobileRepository.SearchMobile(mobile);
        }

    }
}

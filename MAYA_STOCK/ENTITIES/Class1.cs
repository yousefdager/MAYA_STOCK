using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq ; ///////1
using System.Data.Linq.Mapping ; //2

namespace MAYA_STOCK.ENTITIES
{

    [Table (Name = "ADMIN_USERS")]
    class Class1
    {
        [Column(Name = "USER_ID")]
        public Int32  USER_ID { get; set;}
        [Column(Name = "USER_NAME")]
        public string user_name { get; set; }
        [Column(Name = "ACTIVE_FLG")]
        public Int32  active_flg { get; set; }
        [Column(Name = "USER_TYPE")]
        public Int32  user_type { get; set; }
        [Column(Name = "PASSWORD")]
        public string password { get; set; }


    }
}

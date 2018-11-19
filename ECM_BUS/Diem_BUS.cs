using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class Diem_BUS
    {
        public List<Diem_DTO> danhSachDiemHV()
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.LoadDiemHV();
        }
    }
}

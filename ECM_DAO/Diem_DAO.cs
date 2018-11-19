using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class Diem_DAO
    {
        public List<Diem_DTO> LoadDiemHV()
        {
            SqlConnection con = DataProvider.TaoKetNoi();
            List<Diem_DTO> listD = new List<Diem_DTO>();
            string truyvan = @"Select * From NhanVien Where TrangThai = 1 AND ChucVu = 'CV04'";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(truyvan, con);
            while (sdr.Read())
            {
                Diem_DTO diem = new Diem_DTO()
                {
                    MaHV = sdr["MaHV"].ToString(),
                    MaKhoaHoc = sdr["MaKhoaHoc"].ToString(),
                    DiemHV = (float)sdr["DiemHV"],
                    TrangThai = int.Parse(sdr["TrangThai"].ToString())
                };
                listD.Add(diem);
            }
            sdr.Close();
            con.Close();
            return listD;
        }
    }
}

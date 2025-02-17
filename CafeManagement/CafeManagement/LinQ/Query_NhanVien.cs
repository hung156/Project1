﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using System.Data.Entity;
using System.IO;

namespace CafeManagement.LinQ
{
   public class Query_NhanVien
    {
        Query_Login login = new Query_Login();
        public bool Add_NV( CaPheContext context, string hoten, string quequan,string chucvu, string cmnd, string sdt,DateTime ngaysinh, DateTime ngayvaolam , byte[] image)
        {
            
            if (KiemTra(context, cmnd) == 0)
            {
                var nhanvien = new NhanVien()
                {
                    HoTenNV = hoten,
                    QueQuan = quequan,
                    ChucVu = chucvu,
                    SDT_NV = sdt,
                    CMND = cmnd,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam,
                    Picture = image
                };
                context.NhanViens.Add(nhanvien);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int KiemTra(CaPheContext context, string cmnd)
        {
            var sp = (from nv in context.NhanViens
                        where nv.CMND.Contains(cmnd)
                        select nv.NhanVienId).SingleOrDefault();
            return sp;
        }
        public bool Delete_NV(CaPheContext context,string cmnd)
        {
          
            int id = KiemTra(context, cmnd);
            Query_TaiKhoan taiKhoan = new Query_TaiKhoan(); 
            if (id!=0)
            {
                taiKhoan.Delete_TaiKhoan(id);
                var nhanvien = (from item in context.NhanViens
                                where item.NhanVienId.Equals(id)
                                select item).FirstOrDefault();

                context.NhanViens.Remove(nhanvien);
                context.SaveChanges();
                return true;
            } 
            return false;
        }
        public bool Update_NV(CaPheContext context,int id, string hoten, string quequan,string chucvu, string cmnd, string sdt, DateTime ngaysinh, DateTime ngayvaolam,byte[] image)
        {
            if (id != 0)
            {
                var nhanvien = (from item in context.NhanViens
                                where item.NhanVienId.Equals(id)
                                select item).FirstOrDefault();

                nhanvien.QueQuan = quequan;
                nhanvien.HoTenNV = hoten;
                nhanvien.ChucVu = chucvu;
                nhanvien.SDT_NV = sdt;
                nhanvien.CMND = cmnd;
                nhanvien.NgaySinh = ngaysinh;
                nhanvien.NgayVaoLam = ngayvaolam;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayNhanVienIDbyCMND(CaPheContext caPheContext,string CMND)
        { 
            return  (from item in caPheContext.NhanViens
                         where item.CMND.Equals(CMND)
                     select item.NhanVienId).SingleOrDefault();
        }
   
        public NhanVien GetNhanVien(CaPheContext context)
        {
            var nv = (from nhanvien in context.NhanViens
                      where nhanvien.NhanVienId.Equals(Global.NhanVienID)
                      select nhanvien).FirstOrDefault();        
            return nv;        
        }
        public bool CapNhat_NV(CaPheContext context,int id, string hoten, string quequan, string chucvu, string cmnd, string sdt, DateTime ngaysinh, DateTime ngayvaolam, byte[] image)
        {
            if (id != 0)
            {
              
                var nhanvien = (from item in context.NhanViens
                                where item.NhanVienId.Equals(id)
                                select item).FirstOrDefault();

                nhanvien.QueQuan = quequan;
                nhanvien.HoTenNV = hoten;
                nhanvien.ChucVu = chucvu;
                nhanvien.SDT_NV = sdt;
                nhanvien.CMND = cmnd;
                nhanvien.NgaySinh = ngaysinh;
                nhanvien.NgayVaoLam = ngayvaolam;

                context.SaveChanges();
                return true;
            }
            return false;
        }
        public string LayTenNhanVienbyNhanVienID(int NhanVienID,CaPheContext caPheContext)
        {
            return (from item in caPheContext.NhanViens
                         where item.NhanVienId.Equals(NhanVienID)
                         select item.HoTenNV).SingleOrDefault();
        }
    }
}

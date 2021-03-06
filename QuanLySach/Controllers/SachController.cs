using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuanLySach.Models;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach { Id = 1, Title = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", 
                AuthorName = "Nguyễn Nhật Ánh", Price = 1, 
                Content="Truyện Kể Về Tuổi Thơ ..."},
            new Sach { Id = 2, Title = "Cho Tôi Xin Một Vé Về Tuổi Thơ", 
                AuthorName = "Phan Văn Tuấn",
                Content = "Truyện Kể Về Tuổi Thơ ...", Price = 3.75M},
            new Sach { Id = 3, Title = "Tôi Thấy Hoa Vàng Trong Ngân Hàng",
                AuthorName = "Nguyễn Nhật Ánh", Price = 1.7M,
                Content="Truyện Kể Về Tuổi Thơ ..."},
            new Sach { Id = 4, Title = "Cho Tôi Xin Một Vé Về Tắm Ao",
                AuthorName = "Phan Văn Tuấn",
                Content = "Truyện Kể Về Tuổi Thơ ...", Price = 3.75M},
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach (int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}

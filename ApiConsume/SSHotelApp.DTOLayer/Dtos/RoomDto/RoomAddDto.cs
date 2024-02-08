using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.DTOLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lütfen Oda Numarasını Giriniz..")]
        public string RoomNumber { get; set; } = null!;
        public string RoomCoverImage { get; set; } = null!;
        [Required(ErrorMessage ="Lütfen Fiyat Bilgisi Giriniz..")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz..")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Bilgisi Giriniz..")]
        public string BedCount { get; set; } = null!;
        [Required(ErrorMessage = "Lütfen Banyo Sayısı Bilgisi Giriniz..")]
        public string BathCount { get; set; } = null!;
        public string Wifi { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}

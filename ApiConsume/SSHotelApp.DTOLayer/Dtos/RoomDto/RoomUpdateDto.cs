using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.DTOLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz..")]
        public string RoomNumber { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen Oda Görseli Giriniz..")]
        public string RoomCoverImage { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz..")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz..")]
        [StringLength(100, ErrorMessage = "Lütfen En Fazla 100 Karakter Veri Girişi Yapınız")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen Yatak Sayısı Bilgisi Giriniz..")]
        public string BedCount { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen Banyo Sayısı Bilgisi Giriniz..")]
        public string BathCount { get; set; } = null!;
        public string Wifi { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen Açıklama Bilgisi Giriniz..")]
        public string Description { get; set; } = null!;
    }
}

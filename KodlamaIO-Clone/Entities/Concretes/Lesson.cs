using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Lesson : Entity
    {
        //Buraya Ders Programı, Ders Kaydı, Değerlendirme ve Ödev başlıkları eklenecek.
        //Geliştirilecek...
        public string Name { get; set; }

        public int CourseProgrammeId { get; set; }
        public CourseProgramme CourseProgramme { get; set; }
    }
}
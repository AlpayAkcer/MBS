using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiSistemi.Dto.Categories
{
    public class CategoryAddDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Onay { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models {

    // модель для работы с загружаемыми на сервер файлами
    public class FileModel {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}

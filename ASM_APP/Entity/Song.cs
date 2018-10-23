using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_APP.Entity
{
    class Song
    {
        private string _id;
        private string _name;
        private string _thumbnail;
        private string _signer;
        private string _link;
        private string _author;

        public string id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string thumbnail { get => _thumbnail; set => _thumbnail = value; }
        public string signer { get => _signer; set => _signer = value; }
        public string link { get => _link; set => _link = value; }
        public string author { get => _author; set => _author = value; }
    }
}

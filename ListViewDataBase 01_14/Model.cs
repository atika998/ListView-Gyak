using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDataBase_01_14
{
    public class model
    {
        public struct MyData
        {
            public string Id { get; set; }
            public string FullName { get; set; }
            public DateTime Birth { get; set; }
            public string Number { get; set; }
            public string Email { get; set; }

        }
        public model() { }

        public List<MyData> datas = new List<MyData>();

        public List<MyData> EditData = new List<MyData>();

        public List<MyData> EditedData = new List<MyData>();
        public bool edit = false;

        public void AddData(string id, string name, DateTime birth, string number, string email)
        {
            datas.Add(new MyData
            {
                Id = id,
                FullName = name,
                Birth = birth,
                Number = number,
                Email = email
            });
        }
    }
}

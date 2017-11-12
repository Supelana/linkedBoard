using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedBoard
{
    class Field
    {
        public int No { get; set; }
        public int RowNo { get; set; }
        public int ColumnNo { get; set; }
        public Field Right { get; set; }
        public Field Left { get; set; }
        public Field Up { get; set; }
        public Field Down { get; set; }

        public Field()
        {

        }

        public Field(int no, int rowNo, int columnNo)
        {
            No = no;
            RowNo = rowNo;
            ColumnNo = columnNo;
        }
    }
}

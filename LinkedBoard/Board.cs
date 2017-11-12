using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedBoard
{
    class Board
    {
        public List<Field> Fields { get; set; }
        public int NumberOfFields { get; set; }
        public int NumberOfColumns { get; set; }

        public Board(int numberOfFields, int numberOfColumns)
        {
            NumberOfFields = numberOfFields;
            NumberOfColumns = numberOfColumns;
        }

        public void CreateFields()
        {
            Fields = new List<Field>();
            Field field;
            int currentRowNo = 1;
            int currentColumnNo = 0;

            for (int i = 0; i < NumberOfFields; i++)
            {
                currentColumnNo++;
                field = new Field(i,currentRowNo,currentColumnNo);
                Fields.Add(field);

                if (currentColumnNo == NumberOfColumns)
                {
                    currentColumnNo = 0;
                    currentRowNo++;
                }
            }
        }

        public void ConnectFields()
        {
            foreach (var field in Fields)
            {
                field.Up = GetUpField(field);
                field.Down = GetDownField(field);
            }     
        }

        public Field GetDownField(Field field)
        {
            if ((field.No + NumberOfColumns) >= Fields.Count)
            {
                return null;
            }

            return Fields[field.No + NumberOfColumns];
        }

        public Field GetUpField(Field field)
        {
            if ((field.No - NumberOfColumns) < 0)
            {
                return null;
            }

            return Fields[field.No - NumberOfColumns];
        }

        public void PrintFields()
        {
            foreach (var field in Fields)
            {
                Console.WriteLine("No: " + field.No);
                Console.WriteLine("Row: " + field.RowNo + " " + "Column: " + field.ColumnNo);

                if (field.Down != null)
                {
                    Console.WriteLine(field.Down.No);
                }
            }
        }
    }
}

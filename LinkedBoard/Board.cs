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
                field = new Field(i, currentRowNo, currentColumnNo);
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
                field.Right = GetRightField(field);
                field.Left = GetLeftField(field);
                field.Up = GetUpField(field);
                field.Down = GetDownField(field);
            }     
        }

        public Field GetRightField(Field field)
        {
            if (field.No + 1 >= Fields.Count)
            {
                return null;
            }

            Field rightField = Fields[field.No + 1];
            if (field.RowNo == rightField.RowNo)
            {
                return rightField;
            }

            return null;
        }

        public Field GetLeftField(Field field)
        {
            if ((field.No - 1) < 0)
            {
                return null;
            }

            Field leftField = Fields[field.No - 1];
            if (field.RowNo == leftField.RowNo)
            {
                return leftField;
            }

            return null;
        }

        public Field GetUpField(Field field)
        {
            if ((field.No - NumberOfColumns) < 0)
            {
                return null;
            }

            return Fields[field.No - NumberOfColumns];
        }

        public Field GetDownField(Field field)
        {
            if ((field.No + NumberOfColumns) >= Fields.Count)
            {
                return null;
            }

            return Fields[field.No + NumberOfColumns];
        }

        public void PrintFields()
        {
            foreach (var field in Fields)
            {
                Console.WriteLine("No: " + field.No);
                Console.WriteLine("Row: " + field.RowNo + " " + "Column: " + field.ColumnNo);

                if (field.Right != null)
                {
                    Console.WriteLine("Right: " + field.Right.No);
                }

                if (field.Left != null)
                {
                    Console.WriteLine("Left: " + field.Left.No);
                }

                if (field.Up != null)
                {
                    Console.WriteLine("Up: " + field.Up.No);
                }

                if (field.Down != null)
                {
                    Console.WriteLine("Down: " + field.Down.No);
                }

                Console.WriteLine("--------------------------------------");
            }
        }
    }
}

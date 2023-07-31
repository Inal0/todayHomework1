using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCroupCourse
{
    
    class Group
    {
       private string GrupNo;
        public int GroupAvg;

        public string GROUPNO
        {
            get
            {
                return GrupNo;
            }
            set
            {
                bool cavab = Check(value);
                if (cavab == true)
                {
                    GrupNo = value;
                }
            }
        }

            public bool Check(string no)
        {

            bool result = false;
            bool Digit = false;
            bool Upper = false;
            if (no.Length == 4)
            {
                if (char.IsUpper(no[0]))
                {
                    Upper = true;
                    for (int i = 1; i < no.Length; i++)
                    {
                        if (char.IsDigit(no[i]))
                        {
                            Digit = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("group nomresinin bas herfi boyuk olmalidir");
                }
            }
            else
            {
                Console.WriteLine("uzunluq 4 eberaber olmalidir");
            }

            result = Digit && Upper;
            return result;
        }
        }
    }
}

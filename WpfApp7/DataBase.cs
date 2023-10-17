using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    class DataBase
    {
        private static DataBase database;
        private ToursDataSetTableAdapters.ToursTableAdapter toursTable;
        private ToursDataSet toursData;
        private DataBase()
        {
            toursTable = new ToursDataSetTableAdapters.ToursTableAdapter();
            toursData = new ToursDataSet();
            toursTable.Fill(toursData.Tours);
        }
             public static DataBase DatabaseInstance
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase();
                }
                return database;
            }
        }

        public ToursDataSetTableAdapters.ToursTableAdapter ToursTableAdapter
        {
            get
            {
                return toursTable;
            }
        }

        public ToursDataSet ToursData
        {
            get
            {
                return toursData;
            }
        }
    }
    }
    
   



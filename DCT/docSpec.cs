using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DCT
{
    class docSpec
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_doc;

        public int Id_doc
        {
            get { return id_doc; }
            set { id_doc = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string count_e;

        public string Counte
        {
            get { return count_e; }
            set { count_e = value; }
        }

        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private string article;

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        private string place;

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

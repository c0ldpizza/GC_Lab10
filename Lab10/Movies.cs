using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movies
    {
        private string title;
        private string category;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public Movies()
        {
            title = "";
            category = "";
        }

        public Movies(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
}

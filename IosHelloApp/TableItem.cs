using System;
using UIKit;
namespace IosHelloApp
{
    public class TableItem
    {

        public string Heading { get; set; }
        public string ImageName { get; set; }

        public UITableViewCellStyle CellStyle
        {
            get { return cellStyle; }
            set { cellStyle = value; }
        }
        protected UITableViewCellStyle cellStyle = UITableViewCellStyle.Subtitle;


        public TableItem()
        {
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PageModel<T>
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int RowCount { get; set; }
        public int PageCount
        {
            get { return RowCount % PageSize == 0 ? RowCount / PageSize : (RowCount / PageSize) + 1; }
        }
        public IEnumerable<T> List { get; set; }
        public PageModel(int pageSize,int rowCount,IEnumerable<T> list )
        {
            this.List = list;
            this.PageSize = pageSize;
            this.RowCount = rowCount;
            
        }

        public int PrevIndex
        {
            get { return PageIndex <= 1 ? 1 : PageIndex - 1; }
        }

        public int NextIndex
        {
            get
            {
                
                return PageIndex > PageCount - 1 ? PageCount : PageIndex + 1;
            }
        }

    }
}
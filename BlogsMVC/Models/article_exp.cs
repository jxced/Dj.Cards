using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlogsMVC.Models
{
    public class article_exp
    {
        // {a.Id,a.Title,u.CnName }
        [DisplayName("序号")]
        public int Id { get; set; }
        [DisplayName("标题")]
        public string Title { get; set; }
        [DisplayName("作者")]
        public string CnName { get; set; }
        [DisplayName("备注")]
        public string Tag { get; set; }

        public int CategoryId { get; set; }

    }
}
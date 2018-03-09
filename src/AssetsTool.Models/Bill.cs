using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 账单名目
        /// </summary>
        [Display(Name = "账单名目")]
        public int Ttile { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Display(Name = "描述")]
        public int Description { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public int Amount { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        [Display(Name = "付款方式")]
        public int PayType { get; set; }
        /// <summary>
        /// 记账日期
        /// </summary>
        [Display(Name = "记账日期")]
        public DateTime PostingDate { get; set; }
        /// <summary>
        /// 账单类型
        /// </summary>
        [Display(Name = "账单类型")]
        public int BillType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}

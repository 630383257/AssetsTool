using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 账单类型
    /// </summary>
    public enum BillType
    {
        /// <summary>
        /// 支出
        /// </summary>
        [Display(Name = "支出")]
        Expend,
        /// <summary>
        /// 收入
        /// </summary>
        [Display(Name = "收入")]
        Income,
        /// <summary>
        /// 投资
        /// </summary>
        [Display(Name = "投资")]
        Invest,
        /// <summary>
        /// 还款
        /// </summary>
        [Display(Name = "还款")]
        Repay,
        /// <summary>
        /// 还款
        /// </summary>
        [Display(Name = "借款")]
        Borrow
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 付款方式
    /// </summary>
    public enum PayType
    {
        /// <summary>
        /// 现金
        /// </summary>
        [Display(Name = "现金")]
        Cash,
        /// <summary>
        /// 支付宝
        /// </summary>
        [Display(Name = "支付宝")]
        Alipay,
        /// <summary>
        /// 微信支付
        /// </summary>
        [Display(Name = "微信支付")]
        WeChatPay,
        /// <summary>
        /// 银行卡
        /// </summary>
        [Display(Name = "银行卡")]
        BankCard,
        /// <summary>
        /// 蚂蚁花呗
        /// </summary>
        [Display(Name = "蚂蚁花呗")]
        AntCheckLater,
        /// <summary>
        /// 蚂蚁借呗
        /// </summary>
        [Display(Name = "蚂蚁借呗")]
        AntsByChanting
    }
}

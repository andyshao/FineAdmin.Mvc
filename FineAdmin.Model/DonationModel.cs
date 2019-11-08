﻿using DapperExtensions;
using System;

namespace FineAdmin.Model
{
    [Table("Donation")]
    public class DonationModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DapperExtensions.Key(true)]
        public int Id { get; set; }
        /// <summary>
        /// 捐赠人
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 捐赠金额
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// 捐赠详情
        /// </summary>
        public string Detail { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
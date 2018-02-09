﻿using Chloe.Entity;
using System;

namespace Model
{
    [Table("T_Evaluate")]
    public class TEvaluateModel
    {

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 类型（0：取票机评价 1：评价器评价）
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string custCardId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 评价流水号
        /// </summary>
        public string controlSeq { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        public string approveSeq { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string approveName { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public string unitSeq { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string unitName { get; set; }

        /// <summary>
        /// 业务处理ID
        /// </summary>
        public int handId { get; set; }

        /// <summary>
        /// 窗口操作员
        /// </summary>
        public string windowUser { get; set; }

        /// <summary>
        /// 窗口号
        /// </summary>
        public string windowNumber { get; set; }

        /// <summary>
        /// 排队号
        /// </summary>
        public string qNumber { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime handleTime { get; set; }

        /// <summary>
        /// 评价结果（0默认1不满意3满意 4非常满意）
        /// </summary>
        public int evaluateResult { get; set; }
        /// <summary>
        /// 服务态度 1-5分
        /// </summary>
        public int evaluateAttitude { get; set; }
        /// <summary>
        /// 完成质量1-5分
        /// </summary>
        public int evaluateQuality { get; set; }
        /// <summary>
        /// 处理效率1-5分
        /// </summary>
        public int evaluateEfficiency { get; set; }
        /// <summary>
        /// 廉洁自律1-5分
        /// </summary>
        public int evaluateHonest { get; set; }

        /// <summary>
        /// 同步状态：0:同步新增 1：同步修改 2：已同步 3：已删除
        /// </summary>
        public int sysFlag { get; set; }

        /// <summary>
        /// 区域编号
        /// </summary>
        public int areaCode { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public int areaId { get; set; }
    }
}


﻿using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class Points
    {
        /// <summary>
        /// 经度
        /// </summary>
        [DeserializeAs(Name = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [DeserializeAs(Name = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 定位时间
        /// </summary>
        [DeserializeAs(Name = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DeserializeAs(Name = "create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        [DeserializeAs(Name = "direction")]
        public int Direction { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        [DeserializeAs(Name = "height")]
        public double Height { get; set; }

        /// <summary>
        /// 速度
        /// </summary>
        [DeserializeAs(Name = "speed")]
        public double Speed { get; set; }

        /// <summary>
        /// 定位精度
        /// </summary>
        [DeserializeAs(Name = "radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 轨迹对应的道路等级
        /// </summary>
        [DeserializeAs(Name = "road_grade")]
        public string RoadGrade { get; set; }

        /// <summary>
        /// 轨迹对应的定位方式（鹰眼分析得出） 
        /// </summary>
        [DeserializeAs(Name = "locate_mode")]
        public string LocateMode { get; set; }

        /// <summary>
        /// 轨迹对应的交通方式（鹰眼分析得出） 
        /// </summary>
        [DeserializeAs(Name = "transport_mode")]
        public string TransportMode { get; set; }

        /// <summary>
        /// 楼层 
        /// </summary>
        [DeserializeAs(Name = "floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type")]
        public string CoordType { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext1")]
        public string Ext1 { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext2")]
        public string Ext2 { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext3")]
        public string Ext3 { get; set; }
    }
}

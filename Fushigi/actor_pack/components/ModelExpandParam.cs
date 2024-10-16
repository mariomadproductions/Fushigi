﻿using Fushigi.Byml.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fushigi.actor_pack.components
{
    [Serializable]
    public class ModelExpandParam
    {
        public List<ModelExpandParamSettings> Settings { get; set; }
    }

    [Serializable]
    public class ModelExpandParamSettings
    {
        [BymlProperty("MinScale", DefaultValue = "")]
        public Vector2 mMinScale { get; set; }

        [BymlProperty("BoneSetting")]
        public ModelExpandBoneSetting mBoneSetting { get; set; }

        [BymlProperty("MatSetting")]
        public ModelExpandMatSetting mMatSetting { get; set; }
    }

    [Serializable]
    public class ModelExpandBoneSetting
    {
        public List<ModelExpandBoneParam> BoneInfoList { get; set; }

        public bool IsUpdateByModelUpdateWldMtx { get; set; }
    }

    [Serializable]
    public class ModelExpandBoneParam
    {
        [BymlProperty("BoneName", DefaultValue = "")]
        public string mBoneName { get; set; }

        [BymlProperty("CalcType", DefaultValue = "")]
        public string mCalcType { get; set; }

        [BymlProperty("ScalingType", DefaultValue = "")]
        public string mScalingType { get; set; }
    }

    [Serializable]
    public class ModelExpandMatSetting
    {
        public bool IsUpdateByModelUpdateWldMtx { get; set; }
    }
}

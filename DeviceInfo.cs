using System;
using System.Collections.Generic;

namespace DeviceInfo
{
    public class Device
    {
        public string Model { get; set; }
        public string Cpu { get; set; }
        public int? Year { get; set; } // nullable if year unknown
        public string Folder { get; set; }

        public override string ToString()
        {
            return $"{Model} ({Cpu}) - Year: {Year}, Zip: {Folder}";
        }
    };
    public static class DeviceRepo
    {
        public static List<Device> devices = new List<Device>
        {
                    // SC9863A devices
                    new Device { Model = "Itel Vision 2s/3", Cpu = "SC9863A", Year = null, Folder = "sc9863a_Itel_Vision_3" },
                    new Device { Model = "Realme C11 2021 / Narzo 50i", Cpu = "SC9863A", Year = 2021, Folder = "sc9863a_Realme_C11_2021_RMX3231_Narzo_50i_RMX3235" },
                    new Device { Model = "Redbeat C1", Cpu = "SC9863A", Year = null, Folder = "sc9863a_Itel_Vision_3" },
                    new Device { Model = "Vortex NS65", Cpu = "SC9863A", Year = null, Folder = "sc9863a_Itel_Vision_3" },
                    new Device { Model = "ZTE Blade A31", Cpu = "SC9863A", Year = null, Folder = "sc9863a_ZTE_Blade_A31" },
                    new Device { Model = "ZTE Blade A51", Cpu = "SC9863A", Year = null, Folder = "sc9863a_ZTE_Blade_A51" },
                    new Device { Model = "ZTE Blade A52", Cpu = "SC9863A", Year = null, Folder = "sc9863a_ZTE_Blade_A52" },
                    new Device { Model = "ZTE Blade A5 2019", Cpu = "SC9863A", Year = 2019, Folder = "sc9863a_ZTE_Blade_A5_2019" },
                    new Device { Model = "ZTE Blade A7 2019", Cpu = "SC9863A", Year = 2019, Folder = "sc9863a_ZTE_Blade_A7_2019" },
                    new Device { Model = "ZTE Blade V2020 Smart", Cpu = "SC9863A", Year = 2020, Folder = "sc9863a_ZTE_Blade_v2020_smart" },
                    new Device { Model = "ZTE Voyage 40se", Cpu = "SC9863A", Year = null, Folder = "sc9863a_ZTE_Voyage_40se_v4" },
                    new Device { Model = "Hisense V40 HLTE229", Cpu = "SC9863A", Year = null, Folder = "sc9863a_Hisense_v40_HLTE229" },

                    // UD710 devices
                    new Device { Model = "Coolpad X10", Cpu = "UD710", Year = 2019, Folder = "ud710_coolpad_x10" },
                    new Device { Model = "Hisense A7", Cpu = "UD710", Year = 2020, Folder = "ud710_hisense_a7" },
                    new Device { Model = "Hisense A7cc", Cpu = "UD710", Year = 2020, Folder = "ud710_hisense_a7cc" },
                    new Device { Model = "Hisense HNR551T", Cpu = "UD710", Year = 2019, Folder = "ud710_hisense_HNR551T" },
                    new Device { Model = "K-Touch Bee A7", Cpu = "UD710", Year = 2019, Folder = "ud710_K-TouchBeeA7" },
                    new Device { Model = "Tyyh 2020", Cpu = "UD710", Year = 2020, Folder = "ud710_tyyh2020" },
                    new Device { Model = "Tyyh 2021 / 360 q10pro", Cpu = "UD710", Year = 2021, Folder = "ud710_tyyh2021" },
                    new Device { Model = "Xiaolajiao 20", Cpu = "UD710", Year = null, Folder = "ud710_xiaolajiao20" },

                    // UMS312 devices
                    new Device { Model = "MEIZU MeiBlue 10/10s", Cpu = "UMS312", Year = 2019, Folder = "ums312_MeiBlue_10_10s" },
                    new Device { Model = "Qin F21pro+", Cpu = "UMS312", Year = null, Folder = "ums312_Qin_F21pro+" },
                    new Device { Model = "PCCY13Pro", Cpu = "UMS312", Year = 2019, Folder = "ums312_PCCY13Pro_by_tg@riziqw" },

                    // UMS512 devices
                    new Device { Model = "Alldocube iplay 50", Cpu = "UMS512", Year = null, Folder = "ums512_alldocube_iplay_50_EN_20230801" },
                    new Device { Model = "GIONEE GT9", Cpu = "UMS512", Year = null, Folder = "ums512_GIONEE_GT9" },
                    new Device { Model = "Hisense A5pro", Cpu = "UMS512", Year = 2020, Folder = "ums512_hisense_a5pro" },
                    new Device { Model = "Hisense A5procc", Cpu = "UMS512", Year = 2020, Folder = "ums512_hisense_a5procc" },
                    new Device { Model = "Hisense hi reader", Cpu = "UMS512", Year = 2020, Folder = "ums512_hisense_hi_reader" },
                    new Device { Model = "Hisense Q5", Cpu = "UMS512", Year = 2020, Folder = "ums512_hisense_q5" },
                    new Device { Model = "Infinix hot 12 play nfc", Cpu = "UMS512", Year = null, Folder = "ums512_infinix_hot_12_play_nfc" },
                    new Device { Model = "Motorola Moto G20", Cpu = "UMS512", Year = null, Folder = "ums512_Motorola_Moto_G20" },
                    new Device { Model = "OYSIN m60p v5000", Cpu = "UMS512", Year = null, Folder = "ums512_OYSIN_m60p_v5000" },
                    new Device { Model = "Realme C21y RMX3261/RMX3263", Cpu = "UMS512", Year = null, Folder = "ums512_Realme_C21y_RMX3261_RMX3263" },
                    new Device { Model = "Realme C25y RMX3269", Cpu = "UMS512", Year = null, Folder = "ums512_Realme_C25y_RMX3269_by_tg@R0rt1z2" },
                    new Device { Model = "Umidigi G1 Max", Cpu = "UMS512", Year = null, Folder = "ums512_Umidigi_G1_Max" },
                    new Device { Model = "ZTE Axon20 4G A2121E P618A01", Cpu = "UMS512", Year = 2020, Folder = "ums512_ZTE_Axon20_4G_A2121E_P618A01" },

                    // UMS9230 devices
                    new Device { Model = "Alldocube iplay 50 mini", Cpu = "UMS9230", Year = null, Folder = "ums9230_alldocube_iplay_50_mini_EN_20230527_EMMC" },
                    new Device { Model = "Baidu Qinghe V20", Cpu = "UMS9230", Year = null, Folder = "ums9230_Baidu_Qinghe_V20" },
                    new Device { Model = "Blackview A85", Cpu = "UMS9230", Year = null, Folder = "ums9230_Blackview_A85" },
                    new Device { Model = "Doogee T10s", Cpu = "UMS9230", Year = null, Folder = "ums9230_Doogee_T10s" },
                    new Device { Model = "Doogee T10", Cpu = "UMS9230", Year = null, Folder = "ums9230_Doogee_T10_EMMC" },
                    new Device { Model = "i15pro", Cpu = "UMS9230", Year = null, Folder = "ums9230_i15pro" },
                    new Device { Model = "IIIF150 B2", Cpu = "UMS9230", Year = null, Folder = "ums9230_IIIF150_B2" },
                    new Device { Model = "Infinix Hot 12pro", Cpu = "UMS9230", Year = null, Folder = "ums9230_Infinix_hot_12_pro" },
                    new Device { Model = "Infinix Hot 30i", Cpu = "UMS9230", Year = null, Folder = "ums9230_Infinix_Hot_30i_base230522" },
                    new Device { Model = "Itel P40+", Cpu = "UMS9230", Year = null, Folder = "ums9230_itel_P40+_base230619_v2" },
                    new Device { Model = "Itel S23", Cpu = "UMS9230", Year = null, Folder = "ums9230_itel_S23_base230605" },
                    new Device { Model = "Itel Vision 3 Plus", Cpu = "UMS9230", Year = null, Folder = "ums9230_itel_vision_3_plus" },
                    new Device { Model = "Itel Vision 5 Plus", Cpu = "UMS9230", Year = null, Folder = "ums9230_itel_vision_5_plus" },
                    new Device { Model = "Moto e13", Cpu = "UMS9230", Year = null, Folder = "ums9230_moto_e13_v2" },
                    new Device { Model = "Moto g04", Cpu = "UMS9230", Year = null, Folder = "ums9230_moto_g04" },
                    new Device { Model = "Moto g14", Cpu = "UMS9230", Year = null, Folder = "ums9230_moto_g14" },
                    new Device { Model = "Nokia G21", Cpu = "UMS9230", Year = null, Folder = "ums9230_Nokia_G21" },
                    new Device { Model = "Realme C31 RMX3501", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_C31_RMX3501" },
                    new Device { Model = "Realme C33 RMX3624", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_C33_RMX3624" },
                    new Device { Model = "Realme C35 RMX3511", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_C35_RMX3511" },
                    new Device { Model = "Realme C51 RMX3830", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_C51_RMX3830" },
                    new Device { Model = "Realme C53 RMX3760/RMX3762", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_C53_RMX3760_RMX3762" },
                    new Device { Model = "Realme narzo 50i prime RMX3506", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_narzo_50i_prime_RMX3506" },
                    new Device { Model = "Realme Note 50 RMX3834", Cpu = "UMS9230", Year = null, Folder = "ums9230_Realme_Note_50_RMX3834" },
                    new Device { Model = "RYHT X90", Cpu = "UMS9230", Year = null, Folder = "ums9230_RYHT_X90" },
                    new Device { Model = "Tecno spark 8c", Cpu = "UMS9230", Year = null, Folder = "ums9230_tecno_spark_8c" },
                    new Device { Model = "Umidigi A15", Cpu = "UMS9230", Year = null, Folder = "ums9230_Umidigi_A15" },
                    new Device { Model = "Umidigi Active T1", Cpu = "UMS9230", Year = null, Folder = "ums9230_Umidigi_Active_T1" },
                    new Device { Model = "Universal EMMC", Cpu = "UMS9230", Year = null, Folder = "ums9230_universal_unlock_EMMC" },
                    new Device { Model = "Universal UFS", Cpu = "UMS9230", Year = null, Folder = "ums9230_universal_unlock_UFS.dangerous" },

                    // UMS9620 devices
                    new Device { Model = "Bihee a89", Cpu = "UMS9620", Year = null, Folder = "ums9620_bihee_a89_v3" },
                    new Device { Model = "Hisense H60", Cpu = "UMS9620", Year = null, Folder = "ums9620_hisense_h60" },
                    new Device { Model = "Anbernic RG 556", Cpu = "UMS9620", Year = null, Folder = "ums9620_RG_556" },
                    new Device { Model = "Anbernic RG Cube", Cpu = "UMS9620", Year = null, Folder = "ums9620_RG_CUBE" },
                    new Device { Model = "TCL T508n", Cpu = "UMS9620", Year = null, Folder = "ums9620_tcl_t508n_v6" },
                    new Device { Model = "Universal dram1", Cpu = "UMS9620", Year = null, Folder = "ums9620_universal_unlock_dramtype1" },
                    new Device { Model = "Universal dram2", Cpu = "UMS9620", Year = null, Folder = "ums9620_universal_unlock_dramtype2" },
                    new Device { Model = "ZTE Universal", Cpu = "UMS9620", Year = null, Folder = "ums9620_ZTE_universal" },
        };
    }
}
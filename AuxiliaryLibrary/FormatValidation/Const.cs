﻿using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AuxiliaryLibrary.FormatValidation
{
    /// <summary>
    /// 常量
    /// </summary>
    public static class Const
    {
        #region 数字
        /// <summary>
        /// 阿拉伯数字
        /// </summary>
        public const string ArabicNumbers = "0123456789";
        /// <summary>
        /// 汉字数字
        /// </summary>
        public const string ChineseNumbers = "零壹贰叁肆伍陆柒捌玖";
        #endregion

        #region 英文字母
        /// <summary>
        /// 小写英文字母
        /// </summary>
        public const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// 大写英文字母
        /// </summary>
        public const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        #endregion

        #region 常用字符常量
        /// <summary>
        /// 点
        /// </summary>
        public const string Dot = ".";
        /// <summary>
        /// 下划线
        /// </summary>
        public const string Underscore = "_";
        /// <summary>
        /// 逗号空格
        /// </summary>
        public const string CommaSpace = ", ";
        /// <summary>
        /// 逗号
        /// </summary>
        public const string Comm = ",";
        /// <summary>
        /// 左括号
        /// </summary>
        public const string OpenParen = "(";
        /// <summary>
        /// 右括号
        /// </summary>
        public const string ClosedParen = ")";
        /// <summary>
        /// 单引号
        /// </summary>
        public const string SingleQuote = "\'";
        /// <summary>
        /// 斜杠
        /// </summary>
        public const string Slash = @"\";
        #endregion

        #region 单位
        /// <summary>
        /// 金额单位
        /// </summary>
        public const string MonetaryUnit = "万仟佰拾亿仟佰拾万仟佰拾元角分";
        #endregion

        #region Encry(加密字符串)
        /// <summary>
        /// 默认缺省字符串
        /// </summary>
        public const string DefaultString = "JceFramework";
        /// <summary>
        /// Base64加密字符串
        /// </summary>
        public const string Base64String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";
        /// <summary>
        /// 临时加密密匙
        /// </summary>
        public const string TempKey = "#s^un2ye21fcn%|f0XpR,+vh";
        /// <summary>
        /// 存储加密密匙
        /// </summary>
        public const string StoreKey = "v^un2d#eI1@Q2%|,a0xO+sJR";
        #endregion

        #region Default(默认)
        /// <summary>
        /// 默认编码，值为UTF-8
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get { return Encoding.UTF8; }
        }
        /// <summary>
        /// 默认区域设置，值为<see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        public static CultureInfo DefaultCultureInfo
        {
            get { return CultureInfo.CurrentCulture; }
        }

        /// <summary>
        /// 空字符串
        /// </summary>
        public static string Empty
        {
            get { return string.Empty; }
        }
        #endregion

        #region RandomString(随机字符串)
        /// <summary>
        /// 随机字符串
        /// </summary>
        public const string RandomString = "0123456789ABCDEFGHIJKMLNOPQRSTUVWXYZ";
        #endregion

        #region FileExtensionDict(文件扩展类型字典)
        /// <summary>
        /// 文件扩展类型字典
        /// </summary>
        public static Dictionary<string, string> FileExtensionDict
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {".*", "application/octet-stream"},
                    {".tif", "image/tiff"},
                    {".001", "application/x-001"},
                    {".301", "application/x-301"},
                    {".323", "text/h323"},
                    {".906", "application/x-906"},
                    {".907", "drawing/907"},
                    {".a11", "application/x-a11"},
                    {".acp", "audio/x-mei-aac"},
                    {".ai", "application/postscript"},
                    {".aif", "audio/aiff"},
                    {".aifc", "audio/aiff"},
                    {".aiff", "audio/aiff"},
                    {".anv", "application/x-anv"},
                    {".asa", "text/asa"},
                    {".asf", "video/x-ms-asf"},
                    {".asp", "text/asp"},
                    {".asx", "video/x-ms-asf"},
                    {".au", "audio/basic"},
                    {".avi", "video/avi"},
                    {".awf", "application/vnd.adobe.workflow"},
                    {".biz", "text/xml"},
                    {".bmp", "application/x-bmp"},
                    {".bot", "application/x-bot"},
                    {".c4t", "application/x-c4t"},
                    {".c90", "application/x-c90"},
                    {".cal", "application/x-cals"},
                    {".cat", "application/vnd.ms-pki.seccat"},
                    {".cdf", "application/x-netcdf"},
                    {".cdr", "application/x-cdr"},
                    {".cel", "application/x-cel"},
                    {".cer", "application/x-x509-ca-cert"},
                    {".cg4", "application/x-g4"},
                    {".cgm", "application/x-cgm"},
                    {".cit", "application/x-cit"},
                    {".class", "java/*"},
                    {".cml", "text/xml"},
                    {".cmp", "application/x-cmp"},
                    {".cmx", "application/x-cmx"},
                    {".cot", "application/x-cot"},
                    {".crl", "application/pkix-crl"},
                    {".crt", "application/x-x509-ca-cert"},
                    {".csi", "application/x-csi"},
                    {".css", "text/css"},
                    {".cut", "application/x-cut"},
                    {".dbf", "application/x-dbf"},
                    {".dbm", "application/x-dbm"},
                    {".dbx", "application/x-dbx"},
                    {".dcd", "text/xml"},
                    {".dcx", "application/x-dcx"},
                    {".der", "application/x-x509-ca-cert"},
                    {".dgn", "application/x-dgn"},
                    {".dib", "application/x-dib"},
                    {".dll", "application/x-msdownload"},
                    {".doc", "application/msword"},
                    {".dot", "application/msword"},
                    {".drw", "application/x-drw"},
                    {".dtd", "text/xml"},
                    {".dwf", "Model/vnd.dwf"},
                    {".dwg", "application/x-dwg"},
                    {".dxb", "application/x-dxb"},
                    {".dxf", "application/x-dxf"},
                    {".edn", "application/vnd.adobe.edn"},
                    {".emf", "application/x-emf"},
                    {".eml", "message/rfc822"},
                    {".ent", "text/xml"},
                    {".epi", "application/x-epi"},
                    {".eps", "application/x-ps"},
                    {".etd", "application/x-ebx"},
                    {".exe", "application/x-msdownload"},
                    {".fax", "image/fax"},
                    {".fdf", "application/vnd.fdf"},
                    {".fif", "application/fractals"},
                    {".fo", "text/xml"},
                    {".frm", "application/x-frm"},
                    {".g4", "application/x-g4"},
                    {".gbr", "application/x-gbr"},
                    {".", "application/x-"},
                    {".gif", "image/gif"},
                    {".gl2", "application/x-gl2"},
                    {".gp4", "application/x-gp4"},
                    {".hgl", "application/x-hgl"},
                    {".hmr", "application/x-hmr"},
                    {".hpg", "application/x-hpgl"},
                    {".hpl", "application/x-hpl"},
                    {".hqx", "application/mac-binhex40"},
                    {".hrf", "application/x-hrf"},
                    {".hta", "application/hta"},
                    {".htc", "text/x-component"},
                    {".htm", "text/html"},
                    {".html", "text/html"},
                    {".htt", "text/webviewhtml"},
                    {".htx", "text/html"},
                    {".icb", "application/x-icb"},
                    {".ico", "image/x-icon"},
                    {".iff", "application/x-iff"},
                    {".ig4", "application/x-g4"},
                    {".igs", "application/x-igs"},
                    {".iii", "application/x-iphone"},
                    {".img", "application/x-img"},
                    {".ins", "application/x-internet-signup"},
                    {".isp", "application/x-internet-signup"},
                    {".IVF", "video/x-ivf"},
                    {".java", "java/*"},
                    {".jfif", "image/jpeg"},
                    {".jpe", "application/x-jpe"},
                    {".jpeg", "image/jpeg"},
                    {".jpg", "image/jpeg"},
                    {".js", "application/x-javascript"},
                    {".jsp", "text/html"},
                    {".la1", "audio/x-liquid-file"},
                    {".lar", "application/x-laplayer-reg"},
                    {".latex", "application/x-latex"},
                    {".lavs", "audio/x-liquid-secure"},
                    {".lbm", "application/x-lbm"},
                    {".lmsff", "audio/x-la-lms"},
                    {".ls", "application/x-javascript"},
                    {".ltr", "application/x-ltr"},
                    {".m1v", "video/x-mpeg"},
                    {".m2v", "video/x-mpeg"},
                    {".m3u", "audio/mpegurl"},
                    {".m4e", "video/mpeg4"},
                    {".mac", "application/x-mac"},
                    {".man", "application/x-troff-man"},
                    {".math", "text/xml"},
                    {".mdb", "application/msaccess"},
                    {".mfp", "application/x-shockwave-flash"},
                    {".mht", "message/rfc822"},
                    {".mhtml", "message/rfc822"},
                    {".mi", "application/x-mi"},
                    {".mid", "audio/mid"},
                    {".midi", "audio/mid"},
                    {".mil", "application/x-mil"},
                    {".mml", "text/xml"},
                    {".mnd", "audio/x-musicnet-download"},
                    {".mns", "audio/x-musicnet-stream"},
                    {".mocha", "application/x-javascript"},
                    {".movie", "video/x-sgi-movie"},
                    {".mp1", "audio/mp1"},
                    {".mp2", "audio/mp2"},
                    {".mp2v", "video/mpeg"},
                    {".mp3", "audio/mp3"},
                    {".mp4", "video/mpeg4"},
                    {".mpa", "video/x-mpg"},
                    {".mpd", "application/vnd.ms-project"},
                    {".mpe", "video/x-mpeg"},
                    {".mpeg", "video/mpg"},
                    {".mpg", "video/mpg"},
                    {".mpga", "audio/rn-mpeg"},
                    {".mpp", "application/vnd.ms-project"},
                    {".mps", "video/x-mpeg"},
                    {".mpt", "application/vnd.ms-project"},
                    {".mpv", "video/mpg"},
                    {".mpv2", "video/mpeg"},
                    {".mpw", "application/vnd.ms-project"},
                    {".mpx", "application/vnd.ms-project"},
                    {".mtx", "text/xml"},
                    {".mxp", "application/x-mmxp"},
                    {".net", "image/pnetvue"},
                    {".nrf", "application/x-nrf"},
                    {".nws", "message/rfc822"},
                    {".odc", "text/x-ms-odc"},
                    {".out", "application/x-out"},
                    {".p10", "application/pkcs10"},
                    {".p12", "application/x-pkcs12"},
                    {".p7b", "application/x-pkcs7-certificates"},
                    {".p7c", "application/pkcs7-mime"},
                    {".p7m", "application/pkcs7-mime"},
                    {".p7r", "application/x-pkcs7-certreqresp"},
                    {".p7s", "application/pkcs7-signature"},
                    {".pc5", "application/x-pc5"},
                    {".pci", "application/x-pci"},
                    {".pcl", "application/x-pcl"},
                    {".pcx", "application/x-pcx"},
                    {".pdf", "application/pdf"},
                    {".pdx", "application/vnd.adobe.pdx"},
                    {".pfx", "application/x-pkcs12"},
                    {".pgl", "application/x-pgl"},
                    {".pic", "application/x-pic"},
                    {".pko", "application/vnd.ms-pki.pko"},
                    {".pl", "application/x-perl"},
                    {".plg", "text/html"},
                    {".pls", "audio/scpls"},
                    {".plt", "application/x-plt"},
                    {".png", "image/png"},
                    {".pot", "application/vnd.ms-powerpoint"},
                    {".ppa", "application/vnd.ms-powerpoint"},
                    {".ppm", "application/x-ppm"},
                    {".pps", "application/vnd.ms-powerpoint"},
                    {".ppt", "application/vnd.ms-powerpoint"},
                    {".pr", "application/x-pr"},
                    {".prf", "application/pics-rules"},
                    {".prn", "application/x-prn"},
                    {".prt", "application/x-prt"},
                    {".ps", "application/x-ps"},
                    {".ptn", "application/x-ptn"},
                    {".pwz", "application/vnd.ms-powerpoint"},
                    {".r3t", "text/vnd.rn-realtext3d"},
                    {".ra", "audio/vnd.rn-realaudio"},
                    {".ram", "audio/x-pn-realaudio"},
                    {".ras", "application/x-ras"},
                    {".rat", "application/rat-file"},
                    {".rdf", "text/xml"},
                    {".rec", "application/vnd.rn-recording"},
                    {".red", "application/x-red"},
                    {".rgb", "application/x-rgb"},
                    {".rjs", "application/vnd.rn-realsystem-rjs"},
                    {".rjt", "application/vnd.rn-realsystem-rjt"},
                    {".rlc", "application/x-rlc"},
                    {".rle", "application/x-rle"},
                    {".rm", "application/vnd.rn-realmedia"},
                    {".rmf", "application/vnd.adobe.rmf"},
                    {".rmi", "audio/mid"},
                    {".rmj", "application/vnd.rn-realsystem-rmj"},
                    {".rmm", "audio/x-pn-realaudio"},
                    {".rmp", "application/vnd.rn-rn_music_package"},
                    {".rms", "application/vnd.rn-realmedia-secure"},
                    {".rmvb", "application/vnd.rn-realmedia-vbr"},
                    {".rmx", "application/vnd.rn-realsystem-rmx"},
                    {".rnx", "application/vnd.rn-realplayer"},
                    {".rp", "image/vnd.rn-realpix"},
                    {".rpm", "audio/x-pn-realaudio-plugin"},
                    {".rsml", "application/vnd.rn-rsml"},
                    {".rt", "text/vnd.rn-realtext"},
                    {".rtf", "application/msword"},
                    {".rv", "video/vnd.rn-realvideo"},
                    {".sam", "application/x-sam"},
                    {".sat", "application/x-sat"},
                    {".sdp", "application/sdp"},
                    {".sdw", "application/x-sdw"},
                    {".sit", "application/x-stuffit"},
                    {".slb", "application/x-slb"},
                    {".sld", "application/x-sld"},
                    {".slk", "drawing/x-slk"},
                    {".smi", "application/smil"},
                    {".smil", "application/smil"},
                    {".smk", "application/x-smk"},
                    {".snd", "audio/basic"},
                    {".sol", "text/plain"},
                    {".sor", "text/plain"},
                    {".spc", "application/x-pkcs7-certificates"},
                    {".spl", "application/futuresplash"},
                    {".spp", "text/xml"},
                    {".ssm", "application/streamingmedia"},
                    {".sst", "application/vnd.ms-pki.certstore"},
                    {".stl", "application/vnd.ms-pki.stl"},
                    {".stm", "text/html"},
                    {".sty", "application/x-sty"},
                    {".svg", "text/xml"},
                    {".swf", "application/x-shockwave-flash"},
                    {".tdf", "application/x-tdf"},
                    {".tg4", "application/x-tg4"},
                    {".tga", "application/x-tga"},
                    {".tiff", "image/tiff"},
                    {".tld", "text/xml"},
                    {".top", "drawing/x-top"},
                    {".torrent", "application/x-bittorrent"},
                    {".tsd", "text/xml"},
                    {".txt", "text/plain"},
                    {".uin", "application/x-icq"},
                    {".uls", "text/iuls"},
                    {".vcf", "text/x-vcard"},
                    {".vda", "application/x-vda"},
                    {".vdx", "application/vnd.visio"},
                    {".vml", "text/xml"},
                    {".vpg", "application/x-vpeg005"},
                    {".vsd", "application/vnd.visio"},
                    {".vss", "application/vnd.visio"},
                    {".vst", "application/vnd.visio"},
                    {".vsw", "application/vnd.visio"},
                    {".vsx", "application/vnd.visio"},
                    {".vtx", "application/vnd.visio"},
                    {".vxml", "text/xml"},
                    {".wav", "audio/wav"},
                    {".wax", "audio/x-ms-wax"},
                    {".wb1", "application/x-wb1"},
                    {".wb2", "application/x-wb2"},
                    {".wb3", "application/x-wb3"},
                    {".wbmp", "image/vnd.wap.wbmp"},
                    {".wiz", "application/msword"},
                    {".wk3", "application/x-wk3"},
                    {".wk4", "application/x-wk4"},
                    {".wkq", "application/x-wkq"},
                    {".wks", "application/x-wks"},
                    {".wm", "video/x-ms-wm"},
                    {".wma", "audio/x-ms-wma"},
                    {".wmd", "application/x-ms-wmd"},
                    {".wmf", "application/x-wmf"},
                    {".wml", "text/vnd.wap.wml"},
                    {".wmv", "video/x-ms-wmv"},
                    {".wmx", "video/x-ms-wmx"},
                    {".wmz", "application/x-ms-wmz"},
                    {".wp6", "application/x-wp6"},
                    {".wpd", "application/x-wpd"},
                    {".wpg", "application/x-wpg"},
                    {".wpl", "application/vnd.ms-wpl"},
                    {".wq1", "application/x-wq1"},
                    {".wr1", "application/x-wr1"},
                    {".wri", "application/x-wri"},
                    {".wrk", "application/x-wrk"},
                    {".ws", "application/x-ws"},
                    {".ws2", "application/x-ws"},
                    {".wsc", "text/scriptlet"},
                    {".wsdl", "text/xml"},
                    {".wvx", "video/x-ms-wvx"},
                    {".xdp", "application/vnd.adobe.xdp"},
                    {".xdr", "text/xml"},
                    {".xfd", "application/vnd.adobe.xfd"},
                    {".xfdf", "application/vnd.adobe.xfdf"},
                    {".xhtml", "text/html"},
                    {".xls", "application/vnd.ms-excel"},
                    {".xlw", "application/x-xlw"},
                    {".xml", "text/xml"},
                    {".xpl", "audio/scpls"},
                    {".xq", "text/xml"},
                    {".xql", "text/xml"},
                    {".xquery", "text/xml"},
                    {".xsd", "text/xml"},
                    {".xsl", "text/xml"},
                    {".xslt", "text/xml"},
                    {".xwd", "application/x-xwd"},
                    {".x_b", "application/x-x_b"},
                    {".sis", "application/vnd.symbian.install"},
                    {".sisx", "application/vnd.symbian.install"},
                    {".x_t", "application/x-x_t"},
                    {".ipa", "application/vnd.iphone"},
                    {".apk", "application/vnd.android.package-archive"},
                    {".xap", "application/x-silverlight-app"}
                };
            }
        }
        #endregion

        #region SimplifiedChinese(常用简体字汉字)
        /// <summary>
        /// 常用简体汉字
        /// </summary>
        public const string SimplifiedChinese = "一乙二十丁厂七卜人入八九几儿了力乃刀又三于干亏士工土才寸下大丈与万上小口巾山千乞川亿个勺久凡及夕丸么广亡门义之尸弓己已子卫也女飞刃习叉马乡丰王井开夫天无元专云扎艺木五支厅不太犬区历尤友匹车巨牙屯比互切瓦止少日中冈贝内水见午牛手毛气升长仁什片仆化仇币仍仅斤爪反介父从今凶分乏公仓月氏勿欠风丹匀乌凤勾文六方火为斗忆订计户认心尺引丑巴孔队办以允予劝双书幻玉刊示末未击打巧正扑扒功扔去甘世古节本术可丙左厉右石布龙平灭轧东卡北占业旧帅归且旦目叶甲申叮电号田由史只央兄叼叫另叨叹四生失禾丘付仗代仙们仪白仔他斥瓜乎丛令用甩印乐句匆册犯外处冬鸟务包饥主市立闪兰半汁汇头汉宁穴它讨写让礼训必议讯记永司尼民出辽奶奴加召皮边发孕圣对台矛纠母幼丝式刑动扛寺吉扣考托老执巩圾扩扫地扬场耳共芒亚芝朽朴机权过臣再协西压厌在有百存而页匠夸夺灰达列死成夹轨邪划迈毕至此贞师尘尖劣光当早吐吓虫曲团同吊吃因吸吗屿帆岁回岂刚则肉网年朱先丢舌竹迁乔伟传乒乓休伍伏优伐延件任伤价份华仰仿伙伪自血向似后行舟全会杀合兆企众爷伞创肌朵杂危旬旨负各名多争色壮冲冰庄庆亦刘齐交次衣产决充妄闭问闯羊并关米灯州汗污江池汤忙兴宇守宅字安讲军许论农讽设访寻那迅尽导异孙阵阳收阶阴防奸如妇好她妈戏羽观欢买红纤级约纪驰巡寿弄麦形进戒吞远违运扶抚坛技坏扰拒找批扯址走抄坝贡攻赤折抓扮抢孝均抛投坟抗坑坊抖护壳志扭块声把报却劫芽花芹芬苍芳严芦劳克苏杆杠杜材村杏极李杨求更束豆两丽医辰励否还歼来连步坚旱盯呈时吴助县里呆园旷围呀吨足邮男困吵串员听吩吹呜吧吼别岗帐财针钉告我乱利秃秀私每兵估体何但伸作伯伶佣低你住位伴身皂佛近彻役返余希坐谷妥含邻岔肝肚肠龟免狂犹角删条卵岛迎饭饮系言冻状亩况床库疗应冷这序辛弃冶忘闲间闷判灶灿弟汪沙汽沃泛沟没沈沉怀忧快完宋宏牢究穷灾良证启评补初社识诉诊词译君灵即层尿尾迟局改张忌际陆阿陈阻附妙妖妨努忍劲鸡驱纯纱纳纲驳纵纷纸纹纺驴纽奉玩环武青责现表规抹拢拔拣担坦押抽拐拖拍者顶拆拥抵拘势抱垃拉拦拌幸招坡披拨择抬其取苦若茂苹苗英范直茄茎茅林枝杯柜析板松枪构杰述枕丧或画卧事刺枣雨卖矿码厕奔奇奋态欧垄妻顷转斩轮软到非叔肯齿些虎虏肾贤尚旺具果味昆国昌畅明易昂典固忠咐呼鸣咏呢岸岩帖罗帜岭凯败贩购图钓制知垂牧物乖刮秆和季委佳侍供使例版侄侦侧凭侨佩货依的迫质欣征往爬彼径所舍金命斧爸采受乳贪念贫肤肺肢肿胀朋股肥服胁周昏鱼兔狐忽狗备饰饱饲变京享店夜庙府底剂郊废净盲放刻育闸闹郑券卷单炒炊炕炎炉沫浅法泄河沾泪油泊沿泡注泻泳泥沸波泼泽治怖性怕怜怪学宝宗定宜审宙官空帘实试郎诗肩房诚衬衫视话诞询该详建肃录隶居届刷屈弦承孟孤陕降限妹姑姐姓始驾参艰线练组细驶织终驻驼绍经贯奏春帮珍玻毒型挂封持项垮挎城挠政赴赵挡挺括拴拾挑指垫挣挤拼挖按挥挪某甚革荐巷带草茧茶荒茫荡荣故胡南药标枯柄栋相查柏柳柱柿栏树要咸威歪研砖厘厚砌砍面耐耍牵残殃轻鸦皆背战点临览竖省削尝是盼眨哄显哑冒映星昨畏趴胃贵界虹虾蚁思蚂虽品咽骂哗咱响哈咬咳哪炭峡罚贱贴骨钞钟钢钥钩卸缸拜看矩怎牲选适秒香种秋科重复竿段便俩贷顺修保促侮俭俗俘信皇泉鬼侵追俊盾待律很须叙剑逃食盆胆胜胞胖脉勉狭狮独狡狱狠贸怨急饶蚀饺饼弯将奖哀亭亮度迹庭疮疯疫疤姿亲音帝施闻阀阁差养美姜叛送类迷前首逆总炼炸炮烂剃洁洪洒浇浊洞测洗活派洽染济洋洲浑浓津恒恢恰恼恨举觉宣室宫宪突穿窃客冠语扁袄祖神祝误诱说诵垦退既屋昼费陡眉孩除险院娃姥姨姻娇怒架贺盈勇怠柔垒绑绒结绕骄绘给络骆绝绞统耕耗艳泰珠班素蚕顽盏匪捞栽捕振载赶起盐捎捏埋捉捆捐损都哲逝捡换挽热恐壶挨耻耽恭莲莫荷获晋恶真框桂档桐株桥桃格校核样根索哥速逗栗配翅辱唇夏础破原套逐烈殊顾轿较顿毙致柴桌虑监紧党晒眠晓鸭晃晌晕蚊哨哭恩唤啊唉罢峰圆贼贿钱钳钻铁铃铅缺氧特牺造乘敌秤租积秧秩称秘透笔笑笋债借值倚倾倒倘俱倡候俯倍倦健臭射躬息徒徐舰舱般航途拿爹爱颂翁脆脂胸胳脏胶脑狸狼逢留皱饿恋桨浆衰高席准座脊症病疾疼疲效离唐资凉站剖竞部旁旅畜阅羞瓶拳粉料益兼烤烘烦烧烛烟递涛浙涝酒涉消浩海涂浴浮流润浪浸涨烫涌悟悄悔悦害宽家宵宴宾窄容宰案请朗诸读扇袜袖袍被祥课谁调冤谅谈谊剥恳展剧屑弱陵陶陷陪娱娘通能难预桑绢绣验继球理捧堵描域掩捷排掉堆推掀授教掏掠培接控探据掘职基著勒黄萌萝菌菜萄菊萍菠营械梦梢梅检梳梯桶救副票戚爽聋袭盛雪辅辆虚雀堂常匙晨睁眯眼悬野啦晚啄距跃略蛇累唱患唯崖崭崇圈铜铲银甜梨犁移笨笼笛符第敏做袋悠偿偶偷您售停偏假得衔盘船斜盒鸽悉欲彩领脚脖脸脱象够猜猪猎猫猛馅馆凑减毫麻痒痕廊康庸鹿盗章竟商族旋望率着盖粘粗粒断剪兽清添淋淹渠渐混渔淘液淡深婆梁渗情惜惭悼惧惕惊惨惯寇寄宿窑密谋谎祸谜逮敢屠弹随蛋隆隐婚婶颈绩绪续骑绳维绵绸绿琴斑替款堪搭塔越趁趋超提堤博揭喜插揪搜煮援裁搁搂搅握揉斯期欺联散惹葬葛董葡敬葱落朝辜葵棒棋植森椅椒棵棍棉棚棕惠惑逼厨厦硬确雁殖裂雄暂雅辈悲紫辉敞赏掌晴暑最量喷晶喇遇喊景践跌跑遗蛙蛛蜓喝喂喘喉幅帽赌赔黑铸铺链销锁锄锅锈锋锐短智毯鹅剩稍程稀税筐等筑策筛筒答筋筝傲傅牌堡集焦傍储奥街惩御循艇舒番释禽腊脾腔鲁猾猴然馋装蛮就痛童阔善羡普粪尊道曾焰港湖渣湿温渴滑湾渡游滋溉愤慌惰愧愉慨割寒富窜窝窗遍裕裤裙谢谣谦属屡强粥疏隔隙絮嫂登缎缓编骗缘瑞魂肆摄摸填搏塌鼓摆携搬摇搞塘摊蒜勤鹊蓝墓幕蓬蓄蒙蒸献禁楚想槐榆楼概赖酬感碍碑碎碰碗碌雷零雾雹输督龄鉴睛睡睬鄙愚暖盟歇暗照跨跳跪路跟遣蛾蜂嗓置罪罩错锡锣锤锦键锯矮辞稠愁筹签简毁舅鼠催傻像躲微愈遥腰腥腹腾腿触解酱痰廉新韵意粮数煎塑慈煤煌满漠源滤滥滔溪溜滚滨粱滩慎誉塞谨福群殿辟障嫌嫁叠缝缠静碧璃墙撇嘉摧截誓境摘摔聚蔽慕暮蔑模榴榜榨歌遭酷酿酸磁愿需弊裳颗嗽蜻蜡蝇蜘赚锹锻舞稳算箩管僚鼻魄貌膜膊膀鲜疑馒裹敲豪膏遮腐瘦辣竭端旗精歉熄熔漆漂漫滴演漏慢寨赛察蜜谱嫩翠熊凳骡缩慧撕撒趣趟撑播撞撤增聪鞋蕉蔬横槽樱橡飘醋醉震霉瞒题暴瞎影踢踏踩踪蝶蝴嘱墨镇靠稻黎稿稼箱箭篇僵躺僻德艘膝膛熟摩颜毅糊遵潜潮懂额慰劈操燕薯薪薄颠橘整融醒餐嘴蹄器赠默镜赞篮邀衡膨雕磨凝辨辩糖糕燃澡激懒壁避缴戴擦鞠藏霜霞瞧蹈螺穗繁辫赢糟糠燥臂翼骤鞭覆蹦镰翻鹰警攀蹲颤瓣爆疆壤耀躁嚼嚷籍魔灌蠢霸露囊罐";
        #endregion

        #region SpellLetter(拼音字母数组)
        /// <summary>
        /// 拼音字母数组
        /// </summary>
        public static string[] SpellLetter = new string[]{
            "A","Ai","An","Ang","Ao","Ba","Bai","Ban","Bang","Bao","Bei","Ben",
            "Beng","Bi","Bian","Biao","Bie","Bin","Bing","Bo","Bu","Ba","Cai","Can",
            "Cang","Cao","Ce","Ceng","Cha","Chai","Chan","Chang","Chao","Che","Chen","Cheng",
            "Chi","Chong","Chou","Chu","Chuai","Chuan","Chuang","Chui","Chun","Chuo","Ci","Cong",
            "Cou","Cu","Cuan","Cui","Cun","Cuo","Da","Dai","Dan","Dang","Dao","De",
            "Deng","Di","Dian","Diao","Die","Ding","Diu","Dong","Dou","Du","Duan","Dui",
            "Dun","Duo","E","En","Er","Fa","Fan","Fang","Fei","Fen","Feng","Fo",
            "Fou","Fu","Ga","Gai","Gan","Gang","Gao","Ge","Gei","Gen","Geng","Gong",
            "Gou","Gu","Gua","Guai","Guan","Guang","Gui","Gun","Guo","Ha","Hai","Han",
            "Hang","Hao","He","Hei","Hen","Heng","Hong","Hou","Hu","Hua","Huai","Huan",
            "Huang","Hui","Hun","Huo","Ji","Jia","Jian","Jiang","Jiao","Jie","Jin","Jing",
            "Jiong","Jiu","Ju","Juan","Jue","Jun","Ka","Kai","Kan","Kang","Kao","Ke",
            "Ken","Keng","Kong","Kou","Ku","Kua","Kuai","Kuan","Kuang","Kui","Kun","Kuo",
            "La","Lai","Lan","Lang","Lao","Le","Lei","Leng","Li","Lia","Lian","Liang",
            "Liao","Lie","Lin","Ling","Liu","Long","Lou","Lu","Lv","Luan","Lue","Lun",
            "Luo","Ma","Mai","Man","Mang","Mao","Me","Mei","Men","Meng","Mi","Mian",
            "Miao","Mie","Min","Ming","Miu","Mo","Mou","Mu","Na","Nai","Nan","Nang",
            "Nao","Ne","Nei","Nen","Neng","Ni","Nian","Niang","Niao","Nie","Nin","Ning",
            "Niu","Nong","Nu","Nv","Nuan","Nue","Nuo","O","Ou","Pa","Pai","Pan",
            "Pang","Pao","Pei","Pen","Peng","Pi","Pian","Piao","Pie","Pin","Ping","Po",
            "Pu","Qi","Qia","Qian","Qiang","Qiao","Qie","Qin","Qing","Qiong","Qiu","Qu",
            "Quan","Que","Qun","Ran","Rang","Rao","Re","Ren","Reng","Ri","Rong","Rou",
            "Ru","Ruan","Rui","Run","Ruo","Sa","Sai","San","Sang","Sao","Se","Sen",
            "Seng","Sha","Shai","Shan","Shang","Shao","She","Shen","Sheng","Shi","Shou","Shu",
            "Shua","Shuai","Shuan","Shuang","Shui","Shun","Shuo","Si","Song","Sou","Su","Suan",
            "Sui","Sun","Suo","Ta","Tai","Tan","Tang","Tao","Te","Teng","Ti","Tian",
            "Tiao","Tie","Ting","Tong","Tou","Tu","Tuan","Tui","Tun","Tuo","Wa","Wai",
            "Wan","Wang","Wei","Wen","Weng","Wo","Wu","Xi","Xia","Xian","Xiang","Xiao",
            "Xie","Xin","Xing","Xiong","Xiu","Xu","Xuan","Xue","Xun","Ya","Yan","Yang",
            "Yao","Ye","Yi","Yin","Ying","Yo","Yong","You","Yu","Yuan","Yue","Yun",
            "Za", "Zai","Zan","Zang","Zao","Ze","Zei","Zen","Zeng","Zha","Zhai","Zhan",
            "Zhang","Zhao","Zhe","Zhen","Zheng","Zhi","Zhong","Zhou","Zhu","Zhua","Zhuai","Zhuan",
            "Zhuang","Zhui","Zhun","Zhuo","Zi","Zong","Zou","Zu","Zuan","Zui","Zun","Zuo"
        };
        #endregion

        #region SpellCode(拼音区编码数组)
        /// <summary>
        /// 拼音区编码数组
        /// </summary>
        public static int[] SpellCode = new int[]{
            -20319,-20317,-20304,-20295,-20292,-20283,-20265,-20257,-20242,-20230,-20051,-20036,
            -20032,-20026,-20002,-19990,-19986,-19982,-19976,-19805,-19784,-19775,-19774,-19763,
            -19756,-19751,-19746,-19741,-19739,-19728,-19725,-19715,-19540,-19531,-19525,-19515,
            -19500,-19484,-19479,-19467,-19289,-19288,-19281,-19275,-19270,-19263,-19261,-19249,
            -19243,-19242,-19238,-19235,-19227,-19224,-19218,-19212,-19038,-19023,-19018,-19006,
            -19003,-18996,-18977,-18961,-18952,-18783,-18774,-18773,-18763,-18756,-18741,-18735,
            -18731,-18722,-18710,-18697,-18696,-18526,-18518,-18501,-18490,-18478,-18463,-18448,
            -18447,-18446,-18239,-18237,-18231,-18220,-18211,-18201,-18184,-18183, -18181,-18012,
            -17997,-17988,-17970,-17964,-17961,-17950,-17947,-17931,-17928,-17922,-17759,-17752,
            -17733,-17730,-17721,-17703,-17701,-17697,-17692,-17683,-17676,-17496,-17487,-17482,
            -17468,-17454,-17433,-17427,-17417,-17202,-17185,-16983,-16970,-16942,-16915,-16733,
            -16708,-16706,-16689,-16664,-16657,-16647,-16474,-16470,-16465,-16459,-16452,-16448,
            -16433,-16429,-16427,-16423,-16419,-16412,-16407,-16403,-16401,-16393,-16220,-16216,
            -16212,-16205,-16202,-16187,-16180,-16171,-16169,-16158,-16155,-15959,-15958,-15944,
            -15933,-15920,-15915,-15903,-15889,-15878,-15707,-15701,-15681,-15667,-15661,-15659,
            -15652,-15640,-15631,-15625,-15454,-15448,-15436,-15435,-15419,-15416,-15408,-15394,
            -15385,-15377,-15375,-15369,-15363,-15362,-15183,-15180,-15165,-15158,-15153,-15150,
            -15149,-15144,-15143,-15141,-15140,-15139,-15128,-15121,-15119,-15117,-15110,-15109,
            -14941,-14937,-14933,-14930,-14929,-14928,-14926,-14922,-14921,-14914,-14908,-14902,
            -14894,-14889,-14882,-14873,-14871,-14857,-14678,-14674,-14670,-14668,-14663,-14654,
            -14645,-14630,-14594,-14429,-14407,-14399,-14384,-14379,-14368,-14355,-14353,-14345,
            -14170,-14159,-14151,-14149,-14145,-14140,-14137,-14135,-14125,-14123,-14122,-14112,
            -14109,-14099,-14097,-14094,-14092,-14090,-14087,-14083,-13917,-13914,-13910,-13907,
            -13906,-13905,-13896,-13894,-13878,-13870,-13859,-13847,-13831,-13658,-13611,-13601,
            -13406,-13404,-13400,-13398,-13395,-13391,-13387,-13383,-13367,-13359,-13356,-13343,
            -13340,-13329,-13326,-13318,-13147,-13138,-13120,-13107,-13096,-13095,-13091,-13076,
            -13068,-13063,-13060,-12888,-12875,-12871,-12860,-12858,-12852,-12849,-12838,-12831,
            -12829,-12812,-12802,-12607,-12597,-12594,-12585,-12556,-12359,-12346,-12320,-12300,
            -12120,-12099,-12089,-12074,-12067,-12058,-12039,-11867,-11861,-11847,-11831,-11798,
            -11781,-11604,-11589,-11536,-11358,-11340,-11339,-11324,-11303,-11097,-11077,-11067,
            -11055,-11052,-11045,-11041,-11038,-11024,-11020,-11019,-11018,-11014,-10838,-10832,
            -10815,-10800,-10790,-10780,-10764,-10587,-10544,-10533,-10519,-10331,-10329,-10328,
            -10322,-10315,-10309,-10307,-10296,-10281,-10274,-10270,-10262,-10260,-10256,-10254
        };
        #endregion

        #region ChinesePinYin(汉字及拼音首字母)
        /// <summary>
        /// 汉字及拼音首字母
        /// </summary>
        public const string ChinesePinYin = "丂k丄s丅x丆m丏m丒c丗s丢d丠q両l丣y并b丩j丮j丯j丱g丳c丵z丷b丼j乀f乁y讈l乆j乑y乕h乗c乚h乛w乢g乣j乤h乧d乨s乪n乫g乬g乭d乮m乯o乲c乴x乵y乶p乷s乸n乹q乺s乻e乼z乽z乿z亀g亁q乱l亃l亄y亅j亇m亊s亐y亖s亗s亘g亜y亝q亚y亣d亪y亯x亰j亱y亴y亶d亷l亸d亹m亼j亽j亾w仈b仌b仏f仐j仒e仚x仛t仜h仢b仦c仧c仩c仭r仮f仯c仱q仴w仸y仹f仺c仼w仾d伀z伂p伃y伄d伅d伆w伇y伈x汲j伌a伒j伓p伔d伖t伜c伝y伡c伣q伨x伩x伬c伭x伮n伱n伳x伵x伷z伹q伻b伾p伿z佀s佁a佄h佅m伫z布b佉q佊b佋z佌c佒y占z佖b佡x佢q佦s佨b徊h佫h佭x佮g佱f佲m佷h佸h佺q佽c侁s侂t侅g来l侇y侊g侌y侎m侐x侒a侓l侕e仑l侘c侙c侚x侜z侞r侟c価s侢d侤t侫n侭j侰j侱c侲z侳z侴h侣l局j侸s侹t侺s侻t侾x俀t俣y系j俆x俇g俈k俉w俋y俌f俍l俒h俓j俔q俕s俖p俙x俛f侠x俢x俤d俥c俧z俫l俬s俰h俲x俴j俵b俶c俷f俹y俻b俼y俽x俿h伥c倁z倂b倃j倅c俩l倇w倈l仓c倊z个g倎t倐s们m倓t倕c幸x倗p倛q倝g倞j倠s倢j仿f値z倧z伦l倯s倰l倱h倲d倳z倴b倵w倶j倷n倸c倹j倻y倽s倿n偀y偁c偂q偄r偅z偆c伟w偊y偋b偍t偐y偑f偒t偓w偔e偖c偗s偘k偙d偛c偝b偞x偠y偡z偢c偣a偦x偧z偨c偩f偪b偫z偭m偮j偯y偰x偱x偲c偳d侧c侦z偸t偹b咱z偼j伪w傁s傂z傃s傄x傆y傇r傉n傊y傋j傌m傎d傏t傐h杰j傒x傓s傔q傕j伧c傗c伞s备b傚x傛r傜y傝t傞s傟y傠f傡b家j傤z傦g傪c傫l佣y傮z偬z傰p傱s传c伛y债z伤s傹j傼h傽z倾q傿y僀d僁x偻l僃b僄b仅j僆l戮l僈m佥q僊x僋t僌y働d僎z僐s侨q僒j僓t僔z仆p僗l僘c僙g僛q僜d僝c僞w僟j僠b僡h僢c僣t僤d侥j偾f僩x僪y僫e僯l僰b雇g僲x僴x僶m僷y僸j价j僺q僼f僽z僾a僿s仪y儁j侬n儃c亿y当d侩k俭j儊c儌j儍s儎z儏c傧b儑a儓t俦c侪c儖l儗y尽j儙q儚m儛w儜n儝q儞n偿c儠l儢l儣k儤b儥y儦b儧z儨z儩s优y儫h儬q儭c儮l儯t儰w儱l储c儳c儴x儵s儶h俪l罗l儹z傩n傥t俨y儽l儾n兂z凶x兊d兑d兎t兏c児e儿e兖y兘s兟s兡b兤h兦w内n两l兪y兯h兲t兾j兿y冃m冄r円y冇m册c冋j冎g冏j冐m胄z冓g冔x冘y冚k冝y冞s冟s冡m冣z冦k冧l冨f冩x幂m冭t冮g冴y冸p冹f冺m冾q冿j凁s凂m凃t凅g净j凊q冻d凎g凐y凒a凓l凔c凕m凖z凗c凘s凙d凚j凛l凞x凟d凢f凣f凥j処c凧y凨f凩k凪n凬f凮f凯k凲g凴p凷k凾h刄r刅c刉j刋q刌c刏j刐d刓w刔j刕l刜f刞q刟d刡m刢l刣z别b刦j刧j删s刬c刯g刱c刲k刴d刵e刼j刾c刭j剅d剆l则z剈y剉c克k刹c剒c剓l剕f剗c剘q剙c剚z刚g剥b剟d剠q剢d剣j剤j剦y剨h剫d剬z剭w剐g剰s剱j剳d剀k创c剶c铲c剸t剹l剺l剻p剼s剾k劀g划h劄z劅z劆l剧j刘l刽g劋j刿g剑j劎j劏t剂j劒j劔j劕z劖c劗z劘m劙l劚z劜y劤j劥k劦x劧z劮y劯z劰m労l劵j劶k劷y劸w効x劺m匡k劼j劽l勀k劲j勂g勄m勅c勆l勈y勊k勌j勍q勎l勏b勑c勓k勔m动d勖x务w勚y勋x勜w胜s劳l勠l勡p势s积j勥j剿c勧q勨x勪q勫f勬j勭t勮j勯d劢m勲x勳x勴l励l勶c勷x劝q匀y勼j勽b匁m匂x匃g匄g匇y匉p匊j匋t匌g匎e匑g匒d匓j匔g匘n匛j匜y匞j匟k匢h匤q匥f匧q匨z匩k匫h匬y匦g汇h匰d匮k匲l匳l匴s匵d匶j匷j匸x匼k匽y区o卂x卄n卆z卋s卌x卍w卐w协x単d卙j卛s卝g卥x卨x卪j卬a卭q卲s卶c恤x却q卼w卽j卾e厀x厁s厃w厇z厈h厊y厎d厏z厐p厑y厒q厓y厔z厖m厗t厍s厛t厜z厞f厡y厤l厧d厪j厫a厬g厌y厯l厰c厱q厉l厳y厣y厵y厷g厸l厹r厺q厼k厽l厾d叀z参c叄c叅c叆a叇d収s叏g叐b叒r叓l叕z叚j叜s叝j叞w叡r丛c叧g叴q叺c叾d叿h吀m吂m吅x吇z寸c吔y吘o吙h吚y吜c吢q吤j吥b吪e吰h吴w呐n吷x吺d吽h吿g呁j吕l呄g呅w呇q呉w呌j呍h尺c呏s呑t呚h呝e呞s呟j呠p呡w呣m呥r呧d呪z呫t呬x呭y呮q呯p呰z呴g呹y呺x呾d呿q咁x咃t咅p咇b咈f咉y咊h咍h咑d咓w咗z咘b咜t咞x咟h咠q咡e咢e咥d咮z咰s咲x咵k咶g咷t咹e咺x呙g咾l哃t哅x哊y哋d哖n哘x哛p哠h员y哢l哣p哤m哫z哬h哯x哰l哱b哴l哵b哶m哸s哹f哻h哾c唀y唂g唃g呗b含h唈y唊j唋t唌d唍w唎l唒q唓c唕z唖y唗d唘q唙d唚q唜m唝g唞d唟g唡l唥l唦s唨z唩w唫j唭q唲e唴q唵a唶j念n唹y唺t唻l唽x啀a啂g啇d啈h啋c啌q啍z啎w问w啑s啒g啓q啔q啗d啘w啚b啝h哑y启q啠z啢l衔x啨q啩g啫z啯g啰l啱y啲d啳q啴c啹j啺t啽a啿d喅y喆z喌z喍c喎w喐h喒z喓y喕m喖h喗y唤h喛h喞j喠z喡w喢s喣x喤h喥d喦y喨l喩y丧s吃c乔q喭y单c喯p喰c哟y喴w営y喸p喺x喼j喿z嗀h嗁t嗂y嗃h呛q啬s嗈y嗊g嗋x吗m嗏c嗐h嗕r嗗w嗙p呜w嗛q嗞z嗠l嗢w嗧j唢s嗭z嗮s嗰g嗱n嗴q哔b嗸a嗹l嗺z嗻z嗼m嗿t嘂j嘃c嘄j嘅k叹t嘇s嘊a嘋x喽l嘐x嘑h嘒h呕o嘕x啧z尝c嘙p嘚d唛m嘝h嘠g嘡t嘢y嘥s嘦j嘨x哗h嘪m嘫r唠l啸x叽j嘳k哓x嘷h呒m嘺q嘼c嘽t嘾d噀x恶e噂z噃f噄c噅h噆z噇c噈c噉d噊j噋t噏x噐q噑h噒l嘘s噕h噖y噚x噛n噝s噞y噟y哒d噡z噣z哝n哕y噧x噭j噮y嗳a噰y哙k噳y喷p噷x吨d噺h噽p噾y噿z咛n嚁d嚂l嚃t嚄h吓h嚈y嚉d嚊x嚋z哜j嚑x嚔t噜l嚖h嚗b嚘y啮n嚚y嚛h嚜m嚝h嚞z嚟l嚠l嚡x嚢n嚤m咽y呖l嚧l咙l嚩p嚪d嚫c嚬p嚭p向x嚰m嚱x嚲d喾k严y嚵c嘤y嚸d嚹l嚺t嚻x嚽c嚾h嚿h啭z嗫n嚣a囃z冁c囆c囇l呓y囋z苏s囍x囎z囏j囐y嘱z囒l囓n囕r囖l囘h囙y囜n団t囥k囦y囧j囨p囩y囱c囬h囮e囯g囲w図t囶g囷q囸r囼t圀g圁y圂h圅h囵l国g圌c围w圎y圏q圐k圑p园y圆y圔y圕t图t圗t团t圙l圚h圛y圝l圞l圠y圡t圢t圤p圥l圦k圧y圫y圱q圲q圴z圵d圶q圷x圸s圼n圽m圿j坁z坃x坄y坅q坆m坈r坉t坋b坒b坓j坔d坕j坖j坘d坙j坢b坣t坥q坧z坬g坮t垧s坱y坲f坴l坵q坸g坹x坽l坾z坿f垁z垇a垈d垉p垊m垍j垎h垏l垐c垑c垔y垕h垖d垗z垘f垙g垚y垜d垝g垞c垟y垥x垨s垪b垬h垯d垰k垱d垳h垵a垶x垷x垹b垺p垻b垼y垽y垾h垿x埀c埁c埄b埅d埆q埇y埈j埉x埊d埌l埍j埐q埑z埓l埖h埗b埛j埜y埞d垭y埢q埣s埥q埦w埧j埨l埩z埪k埫c埬d埮t埰c埲b埳x埵d执z埻z埼q埾j埿n堁k堃k堄n坚j堈g堉y垩e堌g堎l堏f堐y堒k堓a堔s堖n堗t堘c堚h堛b堜l埚g堟z堢b堣y堥m堦j堧r堨a堩g堫z堬y堭h堮e尧y报b堲j堳m场c堶t堷y堸f堹z堺j堻j堼f堽g堾c碱j塀p塁l塂j塃h塅d塆w塇x塉j块k茔y塎y垲k塐s埘s塓m塕w塖c涂t塙q塚z塛l塜p塝b塟z塠d塡t坞w塣z埙x塦z塧a塨g塩y塪x塭w塮x塯l塰h塱l塲c塳p塴b尘c塶l塷l塸o堑q塺m塻m塼z塽s塿l墂b墄q墆z墇z墈k垫d墋c墌z墍x墎g墏q墐j墒s墔c墕y墖t増z墘q墛w坠z墝q墠s墡s墢f墣p墤k墥t墦f墧q墪d墫c墬d墭s堕d墯d墰t墱d墲w墴h墵t墶d墷y墸z墹j墺a墙q垦k墿y壀p壂d壃j壄y壆x坛t壈l壉j壊h壋d壌r壍q壏x壐x壒a压y壖r壗j垒l圹k垆l壛y壜t壝w坏h垄l壠l壡r坜l壣l壥c壦x壧y壨l坝b壪w壭s壮z壱y売m壴z壵z壷h壸k壶h壻x壼k寿s壾m壿d夀s夁y夃g夅j夆f夈z変b夊s夋q夌l夎c夐x夑x夒n夓x夗y夘w夛d夝q夞y够g夡q梦m夣m夦c夨c夬g夰g夲b夳t夵y夶b夻h夽y夹g夿b奀e奃d奅p奆j奊x奌d奍q奂h奒k奓z奙b奛h奜f奝d奞x奟b奡a奣w奤h奦w奥a奨j奁l夺d奫y奬j奭s奋f奯h奰b奱l奲d奵d奷q奺j奻n奼c奾x奿f妀j妅h妉d妋f妎h妏w妐z妑p妔k妕z妘y妚f妜y妆z妟y妠n妡x妦f妧w妬d妰z妱z你n妴y妵t妶x妷z妸e妺m妼b妽s妿e姀h姁x姂f姄m姅b姇f姈l姉z姌r姗s姎y姏g姕z姖j姙r姛d姞j姟g姠x姡h姢j姤g奸j姧j姩n侄z姫z姭x姮h姯g姰j姱h姲y姳m姴l姵p姶y姷y姸y姺x姼s姽g姾q娀s娂h娋s娍c娎x娏m娐f娒m娔k娕c娖c娗t娙x娚n娱y娝b娞n娡z娢h娤z娦p娧t娨m娪w娫y娬w娭a娮y娯y娰s娳l娵j娷s娸q娹x娺z娻d娽l娾a娿e娄l婃c婄p婅j婇c婈l婋x婌s婍q婎h婏f婐w婑w婒t婓f婔f婖t婗n婘j婙j婛j婜q婝d婞x婟h婠w婡l婣y婤z婥c妇f婨l婩a婫h婬y娅y婮j婯l婰d婱x婳h婸d婹y婻n婼c婽j婾t媀y媁w媂d媃r媄m媅d媆r媇q媈h媉w媊q媋c媌m媍f媎j媏d媐y媓h媔m媕a媖y媗x媘j媙w媜z媞t媟x媠d媢m媣r媤s媥p媦w娲w媨c媩h媫j媬b媭x媮t妫g媰c媱y媴y媶r媷r媹l媺m媻p媪a妈m媿k嫀q嫃z嫄y嫅j嫆r嫇m嫈y嫊s嫋n嫍t嫎p嫏l嫐n嫑b嫓p嫕y妪y嫙x嫚m嫛y嫝k嫞y嫟n嫢g嫤j嫥z嫧z嫨h嫪l嫬z嫭h嫮h嫯a嫰n嫲m嫳p嫴g妩w嫶q嫷t嫸z嫹m嫺x娴x嫼m嫽l嫾l嬀g嬁d嬂z嬄y嬅h嬆x嬇k娆r嬊y婵c娇j嬍m嬎f嬏f嬐x嬑y嬒h嬔f嬕s嬘s嫱q嬚l嬛h袅n嬞d嬠c嫒a嬢n嬣n嬷m嬥t嬦c嬧j嬨c嬩y嫔p嬫r嬬r嬭n嬮y嬯t婴y嬱q嬳y嬵m嬶k婶s嬹x嬺n嬻d嬼l嬽y嬾l嬿y孁l孂j娘n孄l孅x孆y孇s孈x孉h孊m孋l娈l孍y孎z孏l孖m孞x孠s孡t孧y孙s孭m孮c孯q孲y孴n孷l学x孹b孻n孼n孾y孪l宂r宆q宊t宍r宎y宐y宑j宒z宔z宖h実s宧y宨t宩s宬c宭q宫g宯x宱z宲b宷c宺h宻m宼k寀c寁z寃y寈q寉h寊z寋j寍n寎b寏h寑q寔s寕n寖j寗n寘z寙y寚b寛k寜n寠j寝q寣h实s宁n审s寪w写x宽k寭h寯j寱y寲y寳b寴q宠c宝b寷f寽l対d尀p専z尃f将j专z寻x尌s对d导d尐j尒e尓e尗s尙s尛m尞l尟x尠x尡h尣w尦l尨m尩w尪w尫w尭y尮d尯k尰z尲g尳g尵t尶g尴g屃x届j屇t屌d屍s屒z屓x屔n屖x屘m屚l屛p屉t扉f屟x屡l层c屧x屦j屩j屪l屫j属s屭x屰n屲w屳x屴l屵a屶h屷h屸h屻r屼w屽h屾s岀c岃y岄y岆y岇a岉w岊j岋e岏w岒q岓q岕j岝z岞z岠j冈g岤x岥p岦l迢t岨j岮t岯p岰a岲k岴q岶p岹t岺l岻d岼p峀x峂t峃x峅b峆h峇b峈l峉e峌d峍l峎e峏e峐g峑q峓y峔m峕s峖a峗w峘h峚m峛l峜f峝t峞w峟y峠q峢l峧j峩e峫x峬b峯f峱n峲l峳y岘x峵r岛d峷s峸c峹t峺g峼g峡x峿w崀l崁k崄x崅q崈c崉t崊l崋h崌j崃l崏m崐k崑k崒z崓g崕y岗g崘l崚l崜d崝z崟y岽d崡h峥z崣w崥p崨j崪z崫j崬d崯y崰z崱z崲h嵛y崵y崶f崷q崸y崹t崺y崻z崼s崿e嵀z嵁k嵂l嵃y嵄m嵅h嵆j嵈h嵉t嵍w嵎y嵏z岚l嵑k岩y嵓y嵔w嵕z嵖c嵗s嵙k嵚q嵜q嵞t嵟c嵠x嵡w嵢c嵣d嵤r嵥j嵦k嵧l嵨w嵪k嵭b嵮d嵰q嵱y嵲n嵳c嵵s嵶r嵷s嵸z嵹j嵺l嵻k嵼y嵾c嵿d嶀t嵝l嶃z崭z嶅a嶆c岖q嶉w嶊z嶋d嶌d嶍x嶎y嶏p嶐l嶑x嶒c嶓b嶔q嶕j嶖y崂l嶘z嶚l嶛l嶜q嶞t嶟z峤j嶡j嶢y嶣j嶤y嶥j嶦z峄y嶨x嶩n嶫y嶬y嶭n嶮x嶯j嶰x嶱k嶲g嶳d嶴a嶵z嶶w嵘r嶹d岭l嶻j屿y岳y嶾y嶿r巀j巁l巂x巃l巄l巇x巈j巉c巊y岿k巌y巎n巐c漓l峦l巓d巅d巕n巗y巘y巙k巚y巜k巟h巠j巣c巤l巪g巬p巭b巯q巵z巶z巸y卺j巺x巻j巼p巿f帀z帄d帇n帊p帋z帍h帎d帒d帓m帗f帞m帟y帠y帡p帢q帣j帤r帅s帨s帩q帪z师s帬q帯d帰g帲p帐z帴j帵w带d帹s帺q帾z帿h帧z幁z帏w幆y幇b幈p幉d幊g幋p幍t幎m幏j幐t幑h幒z幓s幖b帼g帻z幙m幚b幜j幝c帜z幠h币b幤b幦m幧q幨c蒙m帮b帱c幭m幮c幰x幱l幵j幷b干g几j庁t仄z広g庈q庉d庌y庍b庎j庒z庘y庛c庝t庡y庢z庣t庤z庨x庩t庪g库k庬m庮y庯b庰b庱c庲l庴j庻s庼q庽y庿m廀s厕c厢x廃f厩j廅e廆h廇l厦s廋s廌z廍b廎q廏j廔l廕y廗d廘l廙y厨c廜t厮s廞x庙m厂a庑w废f广a廤k廥k廦b廧q廪l廫l庐l廭j廮y廯x廰t痈y廲l厅t廵x廸d廹p廻h廼n廽h弆j弇y弉z弌y弍e弎s弑s吊d弖h弙w弚t弜j弝b弡j弢t弣f弤d弨c弫z弬y弮j弰s弲x弪j弴d张z弶j强j弸p弻b弽s弾d弿j彁g彂f彃b彄k彅j彇x弹d彉g彋h弥m彍g弯w彏j彑j彔l彚h彛y彜y彞y彟h彠h彣w彦y彧y彨c雕d彮y彯p彲c彴z彵t彶j彸z彺w彽d彾l佛f徃w徆x徍w徎c徏z径j従c徔c徖c徝z从c徟z徕l徢x徣j徤j徥s徧b复f旁p徯x徰z徱p徲t徳d徶b彻c徺j徻h徾m徿l忀x忁b忂q忈r忊d忋g忎r忓h忔y忕s忚x忛f応y忞m忟m忢w忣j忥x忦j忨w忩c忬y忯q忰c忲t忳d忴q忶h忷x忹w忺x忼k怇j怈y怉b怋m怌p怐j怑b怗t怘h怚c怞y怟d怢t怣y怤f怬x怮y怰x怲b怳h怴x怶b怷s怸x怹t怺y怽m恀s恄x恅l恒h恇k恈m恉z恊x恌y恏h恑g恓x恔x恖s恗h恘q恛h恞y恟x恠g恡l耻c恦s恮z恱y恲p恴d恵h恷q恾m悀y悁j悂p悦y悆y悇t悈j悊z悋l悎h悏q悐t悑b悓q悕x悗m悘y悙h悜c悞w悡l悢l悤c悥y悧l悩n悪e悮w悰c悳d怅c闷m悷l悹g悺g凄q悾k悿t惀l惁x惂k惃g惄n惇d惈g惉z惌y惍j惎j惏l惐y惒h惓q惔t惖t惗n啜c惛h惞x惢s惣z惤j惥y惪d恼n恽y惵d惷c惸q恻c惼b惽m惾z惿t愃x愄w愅g愇w愊b愋x愌h愐m愑y愒q愓d愔y愖c愗m愘k愙k爱a惬q愝y愞n愡c愢s愥y悫q愩g愬s愭q愮y愯s愰h愱j愳j怆c愵n愶x恺k愸z愹y愺c愻x愼s愽b忾k慀x慁h慂y栗l慅s慆t殷y慉x态t愠y慏m慐g慒c慓p慔m慖g慗c惨c惭c慛c慜m慞z恸t慠a慡s惯g慤q慥z慦j慩l怄o怂s慬q慭y虑l慯s慱t慲m悭q慴s庆q慸d慹z慺l慻j戚q慽q欲y慿p憀l憁c忧y憃c憄z憅t憆c憇q憈q惫b憌q憍j憏c怜l凭p愦k憓h憕c憖y憗y憘x憙x惮d憛t憞d憟s憠j憢x憣f愤f憥l憦l憪x悯m憭l怃w憯c憰j憱c宪x憳t憴s憵p忆y憸x憹n憺d憻t憼j憽s懀w懁x懃q懄q懅j懆s恳k应y怿y檩l懎s懐h懓a懕y懖g懗x懘c懙y懚y懛d懜m懝a怼d懠q懢l懑m懤c懥z懧n恹y懩y懪b懫z懬k懭k懮y懯f懰l懱m惩c懳h懴c懒l怀h悬x懹r忏c懻j惧j懽h慑s恋l戁n戂m戃t戄j戅g戆g钺y戓g戋j戙d戜d戝z戞j戠z戣k戦z戗q戨g戬j戫y戭y戯x战z戱x戏h户h戸h戹e戺s戻t戼m扂d扄s扅y扆y扊y扏q仂l払f扖h扗z扙z扚d扜y扝y扞h扟s叉c扡t扦q扤w扥d扨s扱c扲q扴j扵y扷b扸x抵d扻z扽d抁y抂k拚p抅j擦c抇h抈y抋q抌d抍z殒y抏w抐n抔p抙p抜b抝a択z抣y抦b抧z抩n抪p抭y抮z抰y抲h抳n曳y抶c抷p抸j抺m抾q拀z拁j拃z抛p拏n拑q拕t拝b拞d拠j拡k拤q拪q拫h拰n拵c拸y拹x拺c拻h挀b挃z挄k挅d挆d挊n挋z挍j挏d挐n挒l挓z挔l挕d挗j挘l挙j挜y挦x挧y挩t挬b挭g挮t挰c挱s挳k挴m挵n挷b挸j挻s挼r挟x挿c捀p捁j捄j捇h捈t捊p捑z捒s捓y捔j捖w捗b捘z捙y捚z捛l捜s捝t捠b捤w捥w捦q舍s捪m扪m捬f捯d捰w卷j捳y捴z捵c捸t捹b捼r捽z捾w捿q掁c扫s抡l掅q掆g掋d掍h掑q掓s掔q掕l掗y挣z掚l挂g掜y掝h掞y掟z采c掦t掫z掯k掱p掲j掵m掶j掹m掻s掽p掿n拣j揁z揂j揃j揅y揇n揈h揊p揋w揌z揑n揓s揔z揕z揗x揘h揙b扬y换h揜y揝z揟x揢k揤j揥d揦l揧l揨c揫j揬t挥h揯g揰c揱x揳x揵q揷c背b揺y揻w揼b揾w搃z搄g构g搇q搈r搉q搊c损s搎s搑r搒b搕k摇y捣d搘z搙n搚l搝q擀g搢j搣m搤e搥c搧s搨t搩j搫p搯t搰h搱z搲w搳h搵w抢q搷t搸z搹e搻n搼q搾z摂s摃g摉s摋s摌c摍s摎n摏c摐c掴g摓f摕d摗s摙l摚c摛c掼g摝l搂l摠z摡g摢h摣z摤q摥t摦h摨z摪j摫g摬y摮a挚z摰n摱m摲c抠k摴c摵s抟t摷j掺c摼k摽b摿y撀g撁q撃j撆p捞l撉d撊x撋r撌g撍z撎y撏x撑c挠n撔h撗h搭d捻n撛l撜z撝h挢j撠j撡c掸d拨b撦c撨x撪b抚f撯z撱w扑p揿q撴d撶h撹j挞t撽j挝w捡j拥y擃n掳l擆z择z擈p擉c击j挡d擌s擏q擑j擓k担d擕x擖y擙a据j擛y擜e擝m挤j擡t擥l擧j擨y擩r擪y擫y拟n擭h擮j摈b拧n搁g掷z擳z扩k擵m擶j撷x擸l擹t摆b擞s撸l擽l扰r攁y攃c摅s攅z撵n攇x攈j攊l攋l攌h攍y攎l隆l攐q攑q攓q拦l攕x撄y攗m搀c撺c携x摄s攞l攟j攠m攡c攒c挛l摊t攦l攧d攨w攩d搅j揽l攭l攰g攱g攲q攳x考k攼g攽b敀p敁d敂k敃m敄w敆h敇c敊c敋g敍x敎j敐c敒s敓d敔y败b叙x敚d敜n敟d敠d敡y敤k敥y敧q敨t敩x敪d敭y敮x敯m敱a敳a敌d敶c数s敹l敺q敻x敼y敽j敾s敿j斀z斁d敛l毙b斄l斅x斆x斈x斉q斊q斍j斎z斏l斒b斔y斓l斖w斘s斚j斝j斞y斠j斢t斣d斦y斨q斪q斩z斱z斲z斴l斵z斶c断d斸z斺c斻h斾p斿l旀m旗q旇p旈l旉f旊f旍j旐z旑y旓s旔j旕e旘z旙f旚p旛f旜z旝k旞s旟y旡j旣j旪x旫t旲t旳d旴x旵c旸y旹s旻m旼m旽t旾c旿w昁b昄b昅j升s昈h昉f昋g昍x昑q昒h昖y昗z昘f昚s昛j昜y昞b昡x昢p昣z昤l昦h昩m昪b昫x昬h昮z昰s昲f昳d昷w昸d昹a昺b昻a昽l昿k晀t时s晄h晅x晆k晈j晋j晊z晍t晎h晐g晑x晘h晙j晛x晜k昼z曦x晠s晢z晣z晥w晧h晩w晪t晫z晭z晱s晳x晵q晸z晹y晻a晼w晽l晿c暀w暁x暃f暅g暆y晕y晖h暊x暋m暍y暏s暐w暒q暓m暕j阳y暙c暚y暛s暜p暞j暟k暠g暡w畅c暣q暤h暥y暦l暩j暪m暂z暬x暯m暰c昵n暲z暳h暵h暶x暷c了l暺t暻j暼p暽l暿x曀y曁j曂h曃d晔y曅y历l昙t曈t晓x曊f曋s曍h曎y曏x曐x曑s曒j曓b曔j曕y暧a曘r曚m曞l曟c旷k曡d曣y曤h曥l曧r曨l曪l曫l晒s曭t曮y曯z曱y曵y曶h书s曺c曽z朁c朂x会g朄y朅q朇b朎l朏k朒g朓t朖l朘j朙m朚h朜t朞j朠y朡z朢w朣t朤l朥l胧l术s朰t朲r朳b朶d朷d朸l朹q朻j朼b朾c朿c杁r杄q杅y圬w杊x杋f杍z杒r杔t杕d杗m杘c杙y杚g杛g杝t杢j杣m杤w杦j杧m杫s杬y杮f东d杴x杶c杸s杹h杺x杻c杽c枀s枂w枃j枅j枆m枊a枍y枎f枏n枑h枒y枓d枔x枖y栀z枛z枟y枠h枡s枤d枦l枩s枬z枮x枱s枲x拐g枹b枺m枻y枼y枽y枾s枿n柀b柂d柅n柆l柇h柈b柉f柊z柋d柌c柍y柎f柕m柖s柗s柟n柡y柣z柤z柦d柧g柪a柫f柭b柮w柲b栅s柶s柷z柹s柺g査c柼y柾j栁l栂m栃l栄r栆z栍s栐y栒x栔q栕c栘y栙x栚z栛l栜s栞k栟b栠r栢b栣r栤b栥z栦c栧y栨c栫j栬z栮e栯y栰f栱g栴z栵l栶y栺z栻s栿f桇r桋y桍k桏q桒s桖x桘c桙y桚z桛k桝j桞l桟z桪x桬s桭c桮b桯t桰g桱j桲b桳b桵r桸x桹l桺l桻f桼q桽w桾j杆g梀s梂q梄y梇l梈p梉z梊d梋x梌t梎a梐b梑d梒h梕r梖b梘j梙h梚w梛n梜j条t梞j枭x梠l梡k梣c梥s里l梪d梬y梮j梱k梲z梴c梶w梷j梸l梹b梺x梻x梼d梽z梾l梿l棁z弃q棅b棆l棈q棊q棌c棎c棏d棐f棑p棓b棔h枨c枣z棙l棛y棜y棝g棞j栋d棡g棢w棤q棥f棦c栈z棨q棩y棪y棫y棬j棭y棯s栖q棳z棴f棶l棷z棸z棻f棽c棾q棿n椀w椂l椄j椆c椇j椈j椉c椊z椌k桠y椑b椓z椔z椕b椖p椗d椙c椚m椛h検j椝g椞x椡d椢g椣d椥z椦q椧m椨f椩g椪p椫s椬y椮s椯d椱f椲h椳w椵j椶z椷j椸y椺x椻y椼y椾j楀y楁h楃w楄p楅b楆y楇g楈x楉r杨y楋l楌y楍b楎h楏k楐j楑k楒s枫f楘m楙m楛h楜h楟t楢y楤c楥x楧y桢z楩p楪d楬j业y楯d楰y楲w楳m楴d极j楶j楺r楻h楽l楾h楿k榁m榃t榅w榊s榋c榌b榎j榏y榑b榒n榓m榖g榗j榚y榝s榞y榟z榠m榡s榢j榣y榤j榥h榩q杩m榬y荣r榯s榰z榲w榳t榵r榶t榸z榹s榺s榼k榽x榾g桤q槂s盘p槄t槅g槆c槇d槈n槉j枪q槏q槑m槒x杠g槕z槖t様y槙d槚j槜z槝d槞l槡s槢x槣j槤l槥h槦r椠q椁g槩g槪g槫t槬h槮s槯c槰p槱y桨j槴h槵h槶g槷n槹g槺k槻g槼g槾m樀d桩z樃l樄c枞c樆l樇x樈q樉s樋t樌g樍z樎s樏l梁l樒m楼l樔c樕s樖k标b樚l樛l樜z樝z枢s樠m樢n样y樤t樥p樦z樧s権q樫j樬c樭j樮y樰x樲e樳x樴z樶z樷c朴p树s桦h樻g橀x橁c橂d橃f橅m橆w桡r橉l橊l桥q橌x橍r橎f橏j橑l橒y橓s橔t橕c橖t橗m橚s橜j橝t橞h机j橠n椭t橣n橤r橦t橧z橪y横h橬q橭g橮l橯l橰g橲x橳s橴z橵z橶j橷d橸j橺x橻c橽t橾s橿j檃y檅h檆s檇z檈x柽c檊g檋j檌z檍y檏p檒f檓h档d檕j檖s檘p檙c檚c檛z桧g檝j檞j檟j檡z检j樯q檤d檥y檦b檧s檨s檭y檮c台t檰m檱q檲t槟b檴h檵j檶q檷n柠n檹y檺g槛j檼y檽n檿y櫀q櫁m櫂z柜g櫄c櫅j櫆k櫇p櫉c櫊g櫋m櫌y櫍z櫎h櫏q櫑l櫒s橹l櫔l櫕c櫖l櫗m櫘h櫙o榈l栉z櫜g椟d橼y栎l櫠f櫡z櫣l櫤j橱c櫦q槠z栌l櫩y枥l櫫z榇c櫭j櫮e櫯s櫰h櫱n櫲y栊l櫵q櫶x櫷g榉j櫹x棂l樱y櫼j櫽y櫾y欀x欁n栏l欅j欆s欇s欈w欉c权q欋q欌z欍j欎y椤l欐l欑c栾l欓d欔q欕e榄l欗l欘z欙l欚l欛b欜n欝y欥y欨x欩c欪c欫q欬k欭y欮j欯x欰x欱h欳k欴l欵k欶s欸a欻c欼c钦q欿k歀k歁k歂c歄g歅y歈y歊x歋y歍w歏j欧o歑h歒t歓h歔x歕p歖x歗x歘x歚s歛l歜c歝y欤y歠c欢h歨b歩b歫j歭z歮s歯c歰s歱z岁s歳s歴l歵z歶y归g歺d歽z歾m殁m殀y殅s殈x殌j殎q殐s殑j殔y殕f殗y残c殙h殜d殝z殟w殠c殢t殣j殇s殥y殦c殧j殨k殩c殚d殬d殓l殡b殰d殱j歼j殶z殸q殹y杀s殻k壳k殽x殾x毁h毃q毄j殴o毇h毈d毉y毊x毋w毎m毐a毑j毘p毚c毞b毟m毠j毢s毣m毤t毦e毧r毨x毩j球q毭d毰p毱j毲d毴b毶s毷m毸s毺s毻t毼h毾t毵s氀l氁m氂m氃t氄r毡z氉s氊z氋m氇l氎d氒j気q氜y氝n氞n氠s气q氥x氢q氩y氭d氱y氲y氶z氷b氹d氺s氻l氼n泛f氿g汃p汄z汅m汈d汋z汌c丸w汏d汑t汒m汓q汖p汘q污w汚w汢t汣j汥z汧q汫j汬j汭r汮j汯h汱t汳b汵g汷z汸f决j汼n汿x沀x沄y沇y沊d沋y沍h沎h沑n没m冲c沗h沘b沚z沜p沝z沞z沠p沢z沨f沬m沯z沰t沴l沵m沶y沷f沺t泀s况k泂j泃j泆y泇j泋h泍b泎z泏c泑y泒g泙p泚c泜z泝s泟c泤s泦j泧y泩s泬j泭f泲j泴g泹d洀p洃h洅z洆c洈w洉h洊j洍s洏e洐x洑f洓s洔z洕y洖w洘k洝a洟y洠s洡l洢y洣m洤q洦p洨x泄x洬s洭k洯q洰j洴p汹x洷z洸g洺m洿w浀q浂y浄j浉s浌p浐c浕j浖l浗q浘w浛h浝m浟y浡b浢d浤h浥y浧y浨l浫h浭g浱c浳y浵t浶l浃j浺c浻j浽s浾c浿p涀x涁s涃k涄p涆h泾j涊n涋t涍x涏t涐e涒t涗s涘s涙l涚s涢y涥h涬x涭s涰c涱z涳n涴w涷d涹w涺j涻s凉l涽h涾t淁q淂d淈g淉g淊y淍z淎p淏h淐c淓f淔z淕l淗j泪l淛z淜p淟t淢y淣n渌l淧m淩l沦l淭q淯y淰n淲b淴h渊y涞l淸q浅j淽z淾y淿b渀b渁y渂w渃r渄f渆y渇k済j渉s渋s渏y渒p渓x渕y渘r涣h减j渞q渟t渢f涡g渧t渨w渪r测c渮h渰y渱h渳m渵m渶y渷y渹q渻s渼m渽z浑h渿n湀g湁c湂e湅l湆q湇q湈m湉t凑c湋w湌c湏h湐p湑x湒j湗f湙y湚y湜s湝j浈z湠t湡y湢b湣m湤s湥t湦s涌c湨j湩d湪t湬q湭q汤s湰l湱h湳n湴b湵y湶q湷z湸l湹c湺x湻c湼n湽z満m溁y溂l溄f溇l沩w溊b溋y溌h溍j溎y溑s溒y溓l溔y溕m准z溗c溙t溚t溛w沟g溞s溠z溡s溣l溤m溦w溨z溩w温w溬q溭z溮s溰a溵y溸s溹s湿s溾a溿p滀c滃w沧c灭m滆g滈h滉h滊q涤d滍z荥x滐j滒g滘j滙h滛y滝l滣c滧y滪y滫x沪h滭b滮b滞z滰j滱k渗s滳s滶a卤l浒h滺y滻c滼f滽y滚g满m漀q渔y漃j漄y漅c漇x漈j漊l漋l漌j漍g漎c漑g漒q漖j漗c漘c漙t沤o漛t漜y漝x漞m漟t漡s汉h涟l漥w漦c漧g漨f渍z漮k漰p涨z漴c漵x漷h渐j漺s漻l漼c漽t浆j潀c潂h潃x潄s潅g潈z潉k潊x潌z潏y潐j泼p潒d潓h洁j潕w潖p潗j潙w潚s潜q潝x泻x潠s潡d润r潥s潧z潨c潩y潪z潫w潬t浔x溃k潱y潳t潵s潶h滗b潹c潻s潽p潾l涠w涩s澁s澂c澃j澅h浇a涝l澊c澋j澏h澐y澑l澒h澓f澔h澕h澖x涧j澘s澙x澛l澝n澞y澟l渑m澢d澣h泽d澥x澦y澨s泶x澪l澫w澬z澭y浍k澯c澰l淀d澲y澴h澷m澸g澺y澻s澼p澽j澾t澿q浊z浓n濄g濅j濆p濇s濈j濊h濋c濌t濍s濎d濏s濐z濓l濔m濖s濗m泞n濙y濚y濜j濝q济j濢c濣w涛t濥y濦y濧d濨c濩h濪q滥l濬j濭a潍w滨b濲g濳q濴y濶k濷f濹b溅j濻w泺p濽z滤l濿l瀁y瀂l瀃s瀄z滢y渎d瀈h瀊p渖s瀌b瀍c瀎m浏l瀒s瀓c瀔g濒b瀖h瀗x泸l瀙q瀜r沥l瀞j潇x潆y瀡s瀢w瀤h瀥x瀦z泷l濑l瀩d瀪f瀫h瀬l瀭s瀮l瀯y瀱j潋l瀳j瀴y瀶l瀷y瀸j瀺c瀻d瀼r瀽j澜l瀿f灀s灁y灂z沣f滠s灅l灆l灇c灈q灉y灊q灋f灍j灎y灐y洒s灒z灓l灔y灖m灗s滩t灙d灚j灛c灏h灟z灠l灡l灢n湾w滦l灥x灦x灧y灨g灪y灮g灱x灲x灳h灴h灷z灹z灺x灻c灾z炁q炂z炄n炆w炇p炈y炋p炌k炐p炑m炘x炚g炛g炞b炟d炠x炡z炢z炣k炤z炥f炦b炧x炨x炩l炪z炰p炴y炵t炶s为w炿z烄j烅x烆h烇q烉h烋x烌x烍x烎y乌w烐z烑y烒s烓w烔t烕m烖z烗k烚x烜x烝z烠h烡g烢c烣h烥c烰f烱j烲x烳p烃t烵z烶t烸h烺l烻y烼x烾c烿r焀h焁x焂s焃h焄x焅k焆j焇x焈x焋z焌j焍d焎x焏j焒l焔y焗j焛l焜k焝h焞t焟x焠c无m焢h焣j焤f焥w焧z焨f焩p焪q焫r焬x焮x焳j焴y焵g焸x焹g焻c焼s焽x焾n焿g煀q煁c煂h煃k煄z煆x煇h煈f炼l煋x煍j煏b煐y煑z炜w煓t煔s煕x煖n煗n煘c烟y煚j煛j煝m煟w煠y煡j茕q煣r焕h烦f煪q煫s炀y煭l煯j煰z煱g煴y煵n煶s煷h煹g煻t煼c煾e煿b熀h熁x熂x熃w熅y熆h熇h熈x熉y熋x熌s熍q熎y熐m熑l荧y熓w熕g熖y炝q熚b熛b熜c熝l熞j熡l熢p熣s熤y熥t熦j熧z熩h熪y熫z熭w熮l熯h熰o热r熲j熴k熶c熷z熸j熺x熻x熼y熽x炽c熿h燀c烨y燂t焰y燅x燆q燇j灯d炖d燊s燋q燍s燏y磷l燑t烧s燖x燗l燘m烫t燚y燛j焖m燝z营y燡y燣l燤t灿c燨x燩q燪z燫l烛z燯l燱y燲x燳z烩h燵t燶n燷l燸x燺h燻x烬j燽c焘d燿y爀h爂b爃r爄l爅m爇r爈l爉l爊a爋x爌k烁s爎l爏l炉l爑j爒l爓y爔x爕x爖l爘c爚y烂l爜c爞c爟g爡c爢m爣t爤l爦l爧l爩y爫z争z爮p爯c爲w爳h爴j爷y爼z尔e牀c牁k牂z牃d牄q牅y牉p牊c牋j牎c牏y牐z牑b牓b牕c牗y牍d牚c牜n牞j它t牣r牤m牥f牨g瘪b牫g牬b牭s牰y牱k牳m牶q牷q牸z牻m牼k牵q犂l犃p犅g犆z犇b犈q犉c犌j犎f犐k犑j犓c犔x犕b荦l犗j犘m犙s犚w犁l犜d犝t犞q犠x犡l犊d犣l犤b犥p犦b牺x犨c犩w犪k犫c犮q犱j犲c犳z犵g犺k犻p犼h犽y犾y犿h状z狅k狆z狇m狉p狊j狋y狌s狏t狑l狓p狕y狖y狘x狛b狜k狝x狟h狢h狣z狤j狥x狦s狧t狪t狫l狵m狶x狭x狈b狾z狿y猀s猂h猄j猅p猆f猇x猈b猉q猋b猌y猐q猑k猒y猔z猘z狰z猚y猟l猠c猣z猤g猦f猧w猨y猭c猯t猰y猲h猳j猵p犹y猺y狲s猼b獀s獁m獂h獃d狱y狮s獆h獇q獈y獊c獋h獌m奖j獏m獑c獓a獔h獕s獘b獙b獚h獛p獜l獝x獞t獟y獡s獢x獣s獤d獥j獦g獧j独d獩h狯k猃x猕m狞n獱b获h獳r獴m猎l獶n犷g兽s獭t献x獽r獿n猡l玁x玂q玃j玅m兹c玈l玊s玌q玍g玏l玐b玒h玓d玔c玕g玗y玘q玙y玚c玜h玝w玞f玠j玡y玣b玤b玥y玦j玧m珏j玪j玬d玭p玱q玴y玵a玶p玸f玹x玼c玽g玾j玿s珁c珃r珄s珅s珆y珇z珋l珌b珎z珒j珓j珔j珕l珖g珗x珘z珚y珛x珜y珝x珟s珡q珢y珣x珤b珦x珨x珪g珫c珬x佩p珯l珰d珱y珳w珴e珵c珶d珷w珸w珹c珺j珻m珼b珽t现x珿c琀h琁x琂y琄x琇x琈f琋x琌l琍l琎j琑s琒f琓w琔d琕p琖z琗c琘m琙y琜l琝m琞s琟w琠t琡s琣b琤c琧e琩c琫b琭l琯g琱d琲b琷q琸z琹q珐f琻j琽d琾j珲h瑀y瑂m瑃c瑄x瑅t瑆x瑇d瑈r瑉m玮w瑌r瑍h瑎x瑏c瑐j瑑z瑒y瑓l瑔q瑖d瑝h瑠l瑡s瑢r琐s瑶y瑥w瑧z瑨j莹y玛m瑫t瑬l瑮l琅l瑱t瑲q瑳c瑴j瑵z瑹t瑺c瑻k瑼z瑽c瑿y璂q璄j璅s璆q璈a琏l璌y璍y璏z璑w璒d璓x璔z璕x璖q璗d璘l璙l璚j璛s璝g璟j璡j璢l玑j璤h璥j瑷a璪z璫d璬j璭g璮t璯h环h璱s璲s璳t璴c璵y璶j璷l璸b璹s璻z璼l玺x璾j璿x瓀r瓁w瓂g瓃l瓄d瓅l瓆z瓇r瓈l瓉z琼q瓋t瓌g瓍s瓎l珑l瓐l瓑l瓓l璎y瓕m镶x瓗q瓘g瓙d瓒z瓛h瓝b瓟b瓡z瓥l瓨x瓩q瓪b瓫p瓬f瓭d瓳h瓵y瓸b瓹j瓺c瓻c瓽d瓾w甀z甁p甂b甃z甅l甆c甈q甉x甊l甋d瓯o甎z甐l甒w甔d瓮w甖y甗y甛t甝h甞c甠q甡s产c産c甤r甧s甪l甮f甴y甶f甹p甼t甽z甿m畁b畂m畃x畆m畇y畉f畊g畍j畐f畑t畒m畓d畕j畖w畗d畘n亩m畟j畠t畡g毕b畣d畤z畨f畩y画h畲s畭s畮m畯j异y畱l畳d畵h畷z畺j畻c畽t畾l疀c疁l疂d疄l疅j畴c疈p疉d叠d疌j疍d疎s疐z疓n疕b疘g疛z疞x疢c疦j疧q疨y疩c疭z疶x疷z疺f疻z痱f痀g痁d痆n痋t痌t痎j痏w痐h痑t痓z痗m痉j痚x痜t痝m酸s痡f痥d痩s痬y痮z痯g麻m痵j痶t痷a痸c痹b痻m痽d痾k瘂y瘄c瘆s瘇z瘈z瘉y疯f疡y瘎c瘏t瘑g瘒w痪h瘔k瘖y瘚j瘜x瘝g瘗y疮c瘣h疟n瘨d瘬z瘮s瘯c瘱y瘲z瘶s瘷s瘘l瘻l瘽q疗l癄q癅l痨l痫x癈f瘅d癋h癎x癏g癐g癑n癒y癓w癕y癗l疠l癙s癚d癛l癝l癠j痴c痒y疖j症z癧l癨h癞l癪j癣x瘿y瘾y瘫t癫d癳l癴l癵l癶b癹b発f发f癿q皀b皁z皃m皅p皉c皊l皌m皍j皏p皐g皒e皔h皕b皗c皘q皑a皛x皜h皝h皞h皟z皠c皡h皢x皣y皥h皦j皧a皨x皩h皪l皫p皬h皭j皯g疱p皳q皵q皶z皷g皲j皹j皱z隳h皼g皽z皾d盀q盁y盃b啊a阿a埃a挨a哎a哀a癌a蔼a矮a艾a碍a隘a鞍a氨a安a俺a按a暗a岸a胺a案a肮a昂a盎a凹a敖a熬a翱a袄a傲a懊a澳a芭b捌b扒b叭b吧b笆b八b疤b巴b拔b跋b靶b把b耙b霸b罢b爸b白b柏b百b佰b拜b稗b斑b班b搬b扳b般b颁b板b版b扮b拌b伴b瓣b半b办b绊b邦b梆b榜b膀b绑b棒b磅b蚌b镑b傍b谤b苞b胞b包b褒b盄d盇h盉h盋b盌w盓y盕f盙f盚q盗d盝l盏z盠l盢x监j盦a卢l盨x盩z荡d盫a盬g盭l盰g盳m盵q盷x盺x盻x盽f盿m眀m眂s眃y眅p眆f眊m県x眎s眏y眐z眑y眒s眓h眔d眕z眖k眗j眘s眛m眜m眝z眞z眡s眤n眦z眧c眪b眫p眬l眮t眰d眱d眲n眳m眴s眹z眻y眽m众z眿m睂m睄s睅h睆h睈c睉c睊j睋e睌m睍x睎x困k睒s睓t睔g睕w睖l睗s睘q睙l睁z薄b雹b保b堡b饱b抱b暴b豹b鲍b爆b杯b碑b悲b卑b北b辈b贝b钡b倍b焙b被b奔b本b笨b崩b绷b甭b泵b蹦b迸b逼b鼻b比b鄙b笔b彼b碧b蓖b蔽b毖b庇b闭b敝b弊b必b辟b壁b臂b避b陛b鞭b边b编b贬b扁b便b变b卞b辨b辩b辫b遍b彪b膘b表b鳖b憋b彬b斌b宾b兵b冰b柄b丙b秉b饼b炳b睝l睐l睟s睠j睤b睧h睩l睾g睭z睮y睯h睰m睱x睲x睳h睴h睵z睶c睷j睸m睺h睻x睼t瞁x瞂f瞃w瞆g眯m瞉k瞊d瞋c瞐m瞕z瞖y瞗d瞘k瞙m瞚s瞛c瞜l瞝c瞒m瞡g瞣w瞤s瞦x瞨p瞫s瞮c瞯x瞱y瞲x瞴w瞶g瞷j瞸y瞹a瞺h睑j瞾z矀w矁c矂s矃n矄x矅y矆h矈m矉p矋l矌k矎x矏m矐h矑l矒m矔g矕m矖x矘t矙k瞩z矝j矞y矟s矠z矡j矤s病b玻b菠b播b钵b波b博b勃b搏b铂b箔b伯b帛b舶b脖b膊b渤b泊b驳b捕b卜b哺b补b埠b不b步b簿b部b怖b猜c裁c材c才c财c睬c踩c彩c菜c蔡c餐c蚕c苍c舱c藏c操c糙c槽c曹c草c策c蹭c插c茬c茶c查c碴c搽c察c岔c差c诧c拆c柴c豺c蝉c馋c谗c缠c阐c颤c昌c猖c矦h矨y矪z矫j矰z矱y矴d矵q矷z矹w矺z矻k矼g砃d砄j砅l砆f砇m砈e砊k砋z砎j砏p砐e砓z砕s砙w砛j砞m砠j砡y砢l砤t砨e砪m砫z砮n砯p砱l炮b砳l砵b砶p砽y砿k硁k硂q朱z硄k硆e硈q硉l硊w硋a硍k硏y硑p硓l硔h硘q硙w硚q硛c硜k硞q硟c硠l硣x硖x硥m硦l硧y砗c硩c砚y硰s硱k硲y硳z硴h硵l硶c硹s硺z硻k硽y硾z硿k碀c碁q碂z碃q常c长c肠c敞c唱c倡c超c抄c钞c朝c嘲c潮c巢c吵c炒c车c扯c撤c掣c澈c郴c臣c辰c晨c忱c沉c陈c趁c衬c称c城c橙c成c呈c乘c程c澄c诚c承c逞c骋c秤c持c匙c池c迟c弛c驰c齿c侈c赤c翅c斥c充c虫c崇c抽c酬c踌c稠c愁c筹c仇c绸c瞅c丑c臭c初c出c躇c锄c雏c滁c除c楚c碄l碅j碆b碈m碊j碋h碏x碒y碔w碕q碖l碙n碝r碞y碠d碢t碤y碦k碨w硕s碪z碫d碬x砀d碮t碯n碵t碶q碷d碸f确q码m碿s磀e磃s磄t磆h磇p磈k磌t磍x磎x磏l磑w磒y磓d磖l磗z磘y砖z磛c磜q磝a磞p磟l磠l磡k磢c碜c磤y磥l磦b碛q磩z磪c磫z磮l矶j磱l磳z磵j磶x磸d磹d磻b磼j硗q磾d磿l礀j礂x礄q礆j礇y礈z礉h礊k礋z礌l础c矗c搐c触c处c揣c川c穿c椽c船c喘c串c窗c幢c床c闯c吹c炊c捶c锤c垂c春c椿c醇c唇c淳c纯c蠢c戳c绰c疵c茨c磁c雌c辞c慈c瓷c词c此c刺c赐c次c聪c葱c匆c粗c醋c簇c促c蹿c篡c窜c摧c崔c催c脆c瘁c粹c淬c翠c村c存c磋c撮c搓c措c挫c错c达d答d瘩d打d大d呆a歹d傣d戴d殆d代d贷d袋d待d逮d礍j礏y礐q礑d礒y礔p礕p礖y礗p礘e礚k礛j礜y礝r礟p礠c礡b礢y礣m礥x矿k礧l礨l礩z砺l砾l矾f礭q礮p礯y礰l砻l礲l礳m礵s礷j礸c礹y礽r礿y祂t祃m祄x祆x只z祊b祋d祌z祎y祏s佑y祑z祒t祔f秘b祙m祡c祣l祤y祦w祩z祪g祫x祬z祮g祰g祲j祳s祴g祵k祹t祻g祼g祽z祾l禄l禂d禃z禆b禇c禉y禋y禌z祸h禐y禑x禒x怠d耽d丹d郸d胆d旦d氮d但d淡d诞d蛋d党d刀d蹈d倒d祷d到d稻d悼d道d德d得d的d蹬d登d等d瞪d凳d邓d堤d低d滴d迪d笛d狄d翟d嫡d底d地d蒂d第d帝d弟d递d缔d颠d掂d滇d碘d点d典d靛d电d佃d甸d店d惦d奠d殿d碉d叼d凋d刁d掉d钓d调d跌d爹d碟d蝶d迭d谍d禓s禔z禕y禖m禗s禘d禙b禛z禜y禝j禞g禟t禠s禡m禢t禣f禤x禥q御y禨j禩s禅c禫d禬g禭s礼l禯n祢m禲l禴y禵t禶z禷l禸r禼x秃t秂r秄z秅c秇y籼x秊n秌q秏h秐y秓z秔j秖z秗y秙k秚b秛p秜n秝l秞y秠p秡b秥n秨z秪d秬j秮h秱t秲s秳h秴h秵y秶z秷z秹r秺d秼z秾n秿f稁g稄x税s稇k秆g稉j稊t稌s稏y稐l稑l稒g稓z稕z稖b稘j稙z稛k棱l丁d盯d叮d钉d顶d鼎d锭d定d订d冬d董d懂d侗d恫d洞d兜d抖d陡d豆d逗d痘d都d督d毒d读d堵d睹d赌d杜d镀d肚d度d渡d妒d端d短d锻d段d缎d堆d队d墩d蹲c敦d顿d囤d钝d盾d遁d掇d哆d多d垛d躲d朵d跺d舵d剁d惰d蛾e峨e鹅e俄e额e讹e娥e厄e扼e遏e鄂e饿e恩e而e耳e饵e洱e二e稝p禀b稡z稢y稤l稦y稧x稨b稩j稪f稫p稭j种c稯z稰x稲d稴x稵z稶y稺z稾g谷g穁r穂s穃r穄j穅k穇c穈m穊j穋l稣s颖y穏w穐q穒k穓y穔h穕q穖j穘x穚j穛z穜t穝z穞l穟s穑s秽h穣r穤n穥y穦p穧j穨t稳w穪c穬k穭l穮b穯s穱z穲l穳c穵w穻y穼s穽j穾y窂l窅y窇b窉b窊w窋z窌j窎d窏w窐w窓c窔y窙x窚c窛k窞d窡z窢h贰e罚f筏f伐f乏f阀f法f藩f帆f番f翻f樊f钒f繁f凡f反f返f范f贩f犯f饭f芳f方f肪f房f防f妨f访f纺f放f菲f非f啡f飞f肥f匪f诽f吠f肺f沸f费f芬f酚f吩f氛f分f纷f焚f汾f粉f份f忿f粪f丰f封f蜂f峰f锋f风f烽f逢f冯f缝f讽f奉f凤f否f敷f肤f孵f扶f拂b辐f幅f氟f符f伏f俘f服f窣s窤g窝w洼w窫y穷q窑y窰y窱t窲c窴t窵d窭j窷l窸x窹w窥k窻c窼c窾k竀c竁c竂l竃z窍q竆q窦d竈z竉l窃q竍s竎f竏q竐c竑h竒q竓h竔s竗m竘q竚z竛l竜l竝b竡b竢s竤h竧j竩y竫j竬q竮p竰l竱z竲c竳d竴c竵w竞j竷k竻l竼p竾c笀m笁z笂w笅j笇s笉q笌y笍z笎y笐h笒c笓b笖y笗d笘s笚d笜z笝n笟g笡q笢m笣b笧c笩f笭l浮f涪f福f袱f弗f甫f辅f俯f釜f斧f脯f腑f府f腐f赴f副f覆f赋f傅f付f阜f父f腹f负f富f讣f附f缚f咐f噶g嘎g该g改g概g钙g盖g溉g甘g柑g竿g肝g赶g感g敢g赣g钢g缸g肛g纲g港g篙g皋g高g膏g羔g糕g搞g镐g稿g哥g歌g戈g鸽g胳g疙g割g革g葛g格g蛤g阁g隔g铬g各g给g根g跟g耕g更g庚g羹g笯n笰f笲f笴g笵f笶s笷m笹t筇q笽m笿l筀g筁q筂c筃y筄y筈k筊j笋s筎r筓j筕h筗z筙l筜d筞c筟f筡t筣l筤l筥j筦g笕j筨h筩t筪x筫z筬c筭s筯z筰z筶g筸g筺k筼y筽o筿x箁p箂l箃z箅b箆b箉g箊y笺j箌z箎c筝z箑s箒z箓l箖l箘q箙f箚z箛g箞q箟j箠c箣c箤z箥p箮x箯b箰s箲x箳p箵x箶h箷s箹y箺c箻l箼w箽d箾s箿j节j篂x篃m埂g耿g梗g工g攻g功g恭g龚g供g躬g公g弓g巩g汞g拱g贡g共g钩g勾g苟g狗g垢g购g辜g菇g咕g箍g估g沽g孤g姑g鼓g古g蛊g骨g股g故g顾g固g刮g瓜g寡g褂g乖g怪g棺g关g官g冠g观g管g馆g罐g灌g贯g光g逛g瑰g规g圭g硅g闺g轨g鬼g诡g癸g桂g跪g贵g辊g棍g锅g郭g果g裹g过g哈h篅c篈f筑z篊h箧q篍q篎m篏q篐g篔y篕h篖t篗y篘c篛r篜z篞n篟q筱x篢l篣p笃d篧z篨c筛s篫z篬q篭l篯j篰b篲h筚b篴z篵c篶y篸c篹s篺p篽y篿t箦z簁s簂g簃y簄h簅c簆k簈p簉z簊j篓l簎c簐n蓑s簒c簓s簔s簕l簗z簘x簙b簚m簛s簜d簝l箪d簠f简j簢m篑k簤d簥j簨z簩l箫x簬l簭s簮z簯q簰p簱q簲p簳g簴j簵l簶l檐y簹d簺s簻z簼g签q帘l籂s骸h孩h海h氦h亥h害h骇h酣h憨h邯h韩h涵h寒h函h喊h罕h翰h撼h捍h旱h憾h悍h焊h汗h夯b杭h航h壕h嚎h豪h毫b郝h好h耗h号h浩h呵h喝h荷h菏h核h禾h和h何h合g盒h貉h阂h河h涸h赫h褐h鹤h贺h嘿h黑h痕h很h狠h恨h亨h衡h轰h哄h烘h虹h鸿h洪h宏h弘h红g喉h侯h猴h吼h厚h候h后h呼h乎h忽h瑚h葫h胡h蝴h狐h糊h湖h篮l籄k籅y籆y籇h籈z籉t籊t籎y籏q藤t籑z籒z籓f籔s籕z籖q籗z籘t籙l籚l籛j箨t籝y籞y籁l笼l籡s籢l籣l龠y仠g籦z籧j籨l笾b簖d籫z篱l籭s箩l籯y籰y籱z吁x籵f籶s籷z籸s籹n籺h籾n籿c粀z粁q粂z粃b粄b粅w粆s粇k粈r粊b粋c粌y粍z佂z粏t粐h佹g侀x粔j粖y粙z粚c粛s粠h侼b侽n粣c粦l粨b粩l粫e粬q粭h粯x粰f粴l粤y粶l粷j粸q粺b粻z弧h虎h唬h护h互h花h华h猾h滑h化h话h槐h淮h桓h还h缓h患h豢h宦h幻h荒h慌h黄h磺h蝗h簧h皇h凰h惶h煌h晃h幌h恍h谎h灰h辉h徽h恢h蛔h回h悔h慧h卉h惠h晦h贿h讳h诲h绘h荤h昏h婚h魂h混h豁h活h伙h火h或h惑h霍h货h圾j基j畸j稽j箕j粿g糀h倄y糃t糄b糆m糉z糋j糎l糏x糐f糑n糒b糓g糔x糘j糚z糁s糡j馍m糣s糤s糥n糦x粮l糩k糪b糫h糬s糭z糮x糱n粝l糳z籴d糵n粜t糷l糹s糺j糼g糽z纠j纪j紁c纣z紃x约y纡y纥g纨w纫r纹w紌q纳n紎z紏t纽n紑f紒j纾s纰p紖z纱s紘h纸z级j纭y紝r紞d紟j紣c紥z紦h紨f紩z紪q紬c紭h扎z细x绂f绁x绅s紴b紵z紶q偟h肌j饥j迹j激j讥j鸡j姬j绩j缉j吉j棘j辑j籍j集j及j急j疾j即j嫉j脊j己j蓟j技j偤y冀j季j伎j祭j悸j寄j寂j计j记j既j忌j际j妓j继j嘉j枷j佳j加j荚j颊j贾g甲j钾j假j稼j架j驾j嫁j尖j间j煎j兼j肩j艰j缄j茧j柬j硷j剪j荐j鉴j践j贱j见j键j箭j件j紷l紸z绍s绀g紻y绋f紽t紾z绐d绌c絁s终z弦x组z絅j絇q絈m絉s絊z絋k経j絍r绗h絏x傶q结j絑z絒c傸c絓g絔b绝j絖k絗h絘c絙h絚g绦t絜j絝k绞j絟q絠g络l绚x絣p絤x絥f絧t绒r絩t絪y絫l絬x絭j絯g絰d统t丝s絴x絵h絶j絸j绢j絺c絻w絼z絽l絿q綀s綂t绡x綄h綅q绠g綇x绨t綉x綊x綋h綌x綍f綎t绥s綐d捆k綒f经j綔h綕z綖y綗j綘f健j舰j饯j建j僵j姜j江j疆j蒋j讲j匠j酱j降j蕉j椒j礁j焦j胶j交j郊j骄j嚼j铰j脚j狡j角j饺j缴j教j酵j轿j较j叫j窖j揭j接j皆j秸j街j阶j截j劫j桔j捷j睫j竭j姐j戒j藉j芥g界j借j介j疥j诫j巾j筋j斤j金j兠d今j津j襟j紧j锦j谨j进j靳j禁j近j浸j継j続x综z綝c缍d綟l绿l綡j绻q綤s綧z綨j綩w綪q綫x绶s维w綯t绾w网w綳b缀z綶g綷c纶g绺l绮q绽z綼b绫l绵m緀q緁j緂t緃z绲g緅z緆x缁z緈x緉l绯f緌r緍m緎y総z緐f緑l绪x緓y緔s緕z緖x缃x缂k线x緜m緟c缗m緢m缘y緤x緥b缌s緧q緪g緫z缅m緭w緮f纬w緰x缑g缈m緳x练l緵z缏b緷g緸y缇t緺g荆j兢j茎j睛j晶j鲸j京j惊j精j粳j井j警j景j颈g静j境j敬j镜j靖j竟j炯j窘j揪j究j玖j韭j久j灸j九j酒j救j旧j臼j舅j咎j就j疚j鞠j拘j狙j疽j居j驹j菊j咀j矩j举j沮j聚j拒j巨j具j距j剏c踞j锯j俱j句g炬j捐j鹃j娟j倦j眷j撅j攫j抉j掘j倔j爵j觉j诀j均j菌j钧j军j君j峻j致z緼w緽c緾c緿d縀x縁y縂z縃x縄s縅o縆g縇s萦y缙j缢y缒z縌n縍b縎g縏p绉z缣j縒c縓q縔s縕y縖x縗c縘x縙r縜y缜z缟g缛r縠h縡z縢t县x縤s縥z縦z縧t縨h縩c縪b縬c缡l缩s演y縰x纵z缧l纤q缦m絷z缕l縸m缥p縺l縼x总z縿s繀s繂l繄y缫s缪m襁q繉s繊x繋j繌z繍x繎r繐s缯z繓z织z缮s繖s繗l繘j繙f缭l繛c繜z勩y俊j竣j浚j郡j骏j喀k咖g卡k咯g开k揩k楷j慨k刊k堪k勘k坎k砍k看k康k慷k糠k扛g抗k亢g炕k拷k烤k靠k坷k苛k柯k棵k磕k颗k科k咳h可k渴k刻k客k课k肯k啃k坑k吭h空k恐k孔k控k口k扣k寇k枯k哭k窟k苦k酷k裤k夸k垮k挎k跨k胯k筷k快k款k筐k狂k框k眶k亏k盔k葵k奎k魁k傀g绕r繟c繠r绣x缋h繣h繤z繥x繦q繧w繨d绳s繬s繮j缳h缲q繱c繲x繴b繵d繶y繷n繸s绎y繺s繻x缤b缱q繿l纀p纁x纃z纅y纆m纇l缬x纉z纩k续x累l纎x纐k纑l纒c缨y厠c纗z缵z纙l缆l纝l纞l纮h纴r纻z纼z绖d绤x绬y绹t缊w缐x缞c缷x缹f缻f缼q缾p罀z罁g罃y罆g罇z罉c罊q罋w罂y罍l罎t罏l罒w罓w馈k愧k坤k昆k括g廓k阔k垃l拉l喇l蜡l腊l辣l啦l莱l赖l蓝l婪l阑l兰l谰l览l榔l狼l廊l郎l朗l浪l牢l老l佬l姥l酪l烙l勒l雷l镭l蕾l磊l儡l肋l类l楞l冷l厘l梨l黎l狸l离l理l李l鲤l莉l荔l吏l丽l利l傈l例l俐l罙s罛g罜z罝j罞m罠m罣g罤t罥j罦f罧s罫g罬z罭y罯a罳s骂m罶l罸f罺c呩s罻w罼b罽j罿c羀l羂j羃m羄z罴p羇j羁j羉l羍d羏y羐l羑y羓b羕y羖g羗q羙m羠y羢r羟q羡x义y羬x羱y羴s羺n羾h翀c翃h翆c翇f翈x翉b翋l翍p翏l翐z翑q习x翓x翖x翗k翙h翚h翛x翜s翝h翞j翢d翣s哷l痢l立l粒l隶l力l璃l哩l联l莲l连l镰l廉l脸l链i啅z粱l良l辆l量l晾l亮l谅l撩l聊l僚l燎l寥l辽l潦l撂l镣l廖l料l列l烈l劣l琳l林l霖l临l邻l鳞l淋l赁l啙z啛c吝l拎l玲l菱l零l龄l铃l伶l羚l凌l灵l陵l领l另l令l溜l琉l榴l硫l馏l留l瘤l流l柳l六l龙l聋l窿l翤c翧x翨c翪z翫w翬h翯h翲p翴l翵h翶a翷l翸p翘q翽h翾x翿d耂l耇g耈g耉g耊d耎n耏n耓t耚p嗘j耝q耞j耟j耡c耣l耤j耫z耧l耭j耮l耯h耰y耲h耴y耹q耺y耼d耾h聀z聄z聅c聇z聈y聉w聏e聐y聑t聓x聕h圣s聗l聙j聛b聜d聝g闻w聟x聠p聡c聢x聣n聤t聥j聦c聧k聨l聫l聬w聭k聮l声s耸s聴t聩k聂n职z聸d聍n聺q聻n嘓g聼t听t拢l陇l漏l陋l芦l颅l虏l鲁l麓l碌l露l路l赂l鹿l潞l录l陆l驴l铝l旅l履l氯l律l率l卵l掠l略l轮l噵d论l萝l螺l逻l锣l骡l裸g落l洛l嚍j骆l嚒m蚂m马m嘛m埋m买m麦m卖m迈m脉m馒m蛮m蔓m曼m慢m漫m肁z肂s肃s肈z肊y肍q肎k肏c肐g肑d囄l肔c肕r肗r肙y肞c肣q肦b肧p肨p肬y肰r肳w肵q肶p肹x肻k胅d胇b胈b胉b胊q坺f垀h胏z胐f胒n胓p胔z胕f胘x胟m胠q胢q胣c胦y胮p胵c胷x胹e埱c埶y胾z胿g脀z脁t脃c脄m胁x脇x脋x脌n脕w脗w脙x胫j脜r脝h脟l脠s脡t脢m脤s脥j塈x睃s脨c修x脪x脱t脭c脮n脰d脳n脴p脵g脷l胀z脼l脽s脿b谩m芒m墽q茫m盲m氓m壔d忙m莽m猫m茅m锚m毛m矛m铆m卯m茂m冒m帽m貌m贸m么m玫m枚m梅m酶m霉m煤m眉m媒m镁m每m美m昧m寐m妹m媚m门m萌m檬m盟m锰m猛m孟m醚m靡m糜m迷m谜m米m觅m泌b蜜m密m棉m眠m冕m免m勉m娩m面m苗m妌j描m瞄m藐m秒m妛c妭b渺m妙m蔑m民m抿m皿m敏m姃z闽m明m螟m鸣m铭m名m命m谬m摸m腀l腁p腂g腃j腄c腅d腇n腉n腍r肾s腏z腒j腖d腗p腘g腛w腜m腝r腞z娊x脶l腢o腣d腤a脑n腨s腪y肿z腬r腯t腲w腵j婂m腶d腷b膁q腽w膄s膅t膆s膇z膉y膋l膌j膍p膎x膐l膒o膓c膔l膕g膖p膗c膙j膞z膟l膡y膢l膤x膥c膧t腻n膫l膬c膭k膮x媑z膯t膰f膱z膲j膴h媝q媡l膵c膶r膷x膸s膼z脍k脓n臄j臅c臇j臈l臋t脐q臎c膑b臐x臑n嫿h嬃x嬓j臓z摹m蘑m模m嬜x膜m磨m摩m嬟y魔m抹m末m莫m墨m默m沫m漠m寞m陌m谋m牟m某m拇m牡m姆m母m墓m暮m幕m募m慕m木m目m孨z睦m牧m穆m拿n哪n孶z钠n那n娜n氖n乃n奶n耐n奈n南n男n难n囊n闹n淖n呢n馁n嫩n能n妮n霓n倪n泥n尼n匿n逆n溺n蔫n拈n年n碾n酿n鸟d尿n捏n孽n镊n镍n涅n您n凝n臔x臕b臖x臗k臙y胪l臛h臜z臝l臞q脏z脔l臡n臢z卧w臦g臩g臫j臮j臯g臰c岅b臲n臵g臶j臷d臸z臹x岟y臽x臿c舃x与y兴x岪f岾z峊f舎s舏j舑t峣y舓s舕t铺p舗p峮q舘g舙h舚t舝x舠d舤f舥p舦t舧f舩c舮l舲l舼q峾y舽p艀f艁z艂f艃l艅y艆l艊b艌n艍j艎h艐k艑b艒m艓d艔d嵽d嶈q艖c艗y艛l艜d艝s艞y艠d艡d艢q舣y艥j艧h艩q牛m扭n钮n嶪y农n弄l奴n努n怒n女n暖n虐n挪n懦n糯n诺n哦e巆y鸥o藕o偶o巏q啪p趴p爬p帕p怕p琶p拍p排p牌p徘p湃p派p攀p潘f磐p盼p畔p判p叛p乓p庞p耪p胖p咆p刨b袍p跑p泡p呸p胚p培p裴p赔p陪p配p沛b盆p砰p抨p烹p澎p彭p蓬p棚p硼p篷p膨p朋p鹏p捧p碰p坯p砒p霹p批p披p劈p琵p毗p艪l舻l艬c艭s艵p艶y艳y艹a艻l艼d幯j庅m庺s芃p芅y芆c芇m廐j芉g芌y苄b芓z芔h芕s弐e芚t芛w芞q芠w芢r芣f芧x芲l弞s芵j芶g芺a刍c芼m芿r苀h苂c苃y苅y苆s苉p苐d苖d苙l苝b苢y苎z苨n苩p苪b苬x苭y苮x苰h徛j苲z徦j苳d苵d苶n苸h苺m苼s苽g苾b苿w徴z茀f徸z茊z茋z茐c茒y茓x茖g茘l忇l茙r茝c茞c怓n茠h茡z茢l茣w茤j茥g茦c茩h茪g茮j怱c茷f茻m茽z啤p脾p疲p皮p匹p恎d痞p僻p屁p譬p篇p偏p片p骗p恜c飘p瓢p票p撇p瞥p拼p频p贫p品p聘p乒p坪p苹p萍p平p瓶p评p屏b坡p颇p婆p破p魄b迫p粕p剖p莆p葡p菩p蒲p埔b圃b普p浦p谱p曝b瀑b期j欺q妻q七q漆q柒q沏q其j棋q奇j歧q畦q崎q愂b齐j祈q祁q起q岂q乞q企q契q器q迄q汽q泣q愪y讫q掐q茾q茿z荁h荂f荄g荅d愲g荈c荋e荌a荍q荎c荓p荕j荖l荗s荘z荙d荝c荢z慃y荰d荱w荲l荳d荴f荵r荶y荹b荺y荾s荿c莀c莁w莂b莃x莄g莇z莈m庄z莋z莌t莏s莐c莑p莔m莕x憉p莗c莙j莚y莝c莟h莡c莣w莤s莥n莦s憜d苋x莬w莭j莮n憡c莯m莵t莻n莾m莿c菂d菃q菄d菆c菈l菉l菋w菍n菎k菐p菑z菒g菓g菕l菗c憿j菙c菚z菛m菞l菢b菣q菤j菦q菧d菨j菫j懏j菬q菭t恰q洽q钎q铅q千q懡m迁q仟q谦q乾q黔q钱q钳q前q遣q谴q嵌k欠q歉q腔q羌q蔷q橇q锹q敲q悄q瞧q巧q鞘q撬q峭q俏q切q茄j且j怯q戵q侵q亲q秦q琴q勤q芹q擒q禽q沁q青q轻q卿q清q擎q晴q氰q情q顷q请q秋q丘q邱q求q囚q抯z酋q泅q趋q蛆q曲q躯q屈q驱q渠q菮g菳q庵a菵w拲g菶b菷z菺j挌g菼t菾t菿d萀h萅c苌c萈h萉f萐s萒y萓y萔t萕q萖w萗c萙k萚t萛j萞b萟y萠p萡b萢p萣d萩q萪k萫x万m萭y萮y萯f萰l萲x萳n萴c掤b莴w萶c萷s萹b萺m萻a萾y葀k葁j葂m葃z葄z葅z葇r葈x叶x葊a葋q葌j葍f葎l葏j葐p荭h葓h搮l摀w葕x葖t葘z葝q葞m葟h葠s葢g葤z摖q葥q苇w葧b葨w葪j葮d药y葰j葲q葴z摾j葹s葻l葼z取q娶q龋q趣q去q圈j颧q醛q泉q全q痊q拳q犬q券q撧j缺q炔g瘸q鹊q榷q裙q群q然r燃r冉r染r瓤r壤r攘r嚷r让r饶r惹r壬r擟m仁r人r忍r韧r任r认r刃r妊r扔r仍r日r戎r茸r擿t攂l蓉r融r熔r溶r攚w容r冗r揉r柔r肉r茹r蠕r儒r孺r如r辱r乳r汝r攺y入r褥r软r阮r蕊r瑞r锐r闰r若r弱r撒s萨s腮s鳃s塞s赛s三s叁s葽y葾y葿m蒀y蒁s蒃z蒄g蒅s蒆x蒍w蒏y蒐s蒑y蒒s蒓c莳s蒕y蒖z蒘r蒚l蒛q蒝y莅l蒟j蒠x蒢c蒣x蒤t蒥l蒦h蒧d蒨q蒩z蒪p蒫c蒬y蒭c蒮y蒰p蒱p蒳n斮z蒵x斳q蒷y蒻r蒾m荪s蓂m蓃s蓅l蓆x蓇g蓈l蓌c蓎t蓏l蓒x蓔y蓕g蓗z蓘g蓙g蓚t蓛c蓜p蓞d蓡s旤h蓢l蓤l蓧d蓨t蓩m蓪t蓫z蓭a苁c蓱p蓲q蓳j蓴c蓵j蓶w蓷t蓸c蓹y蓺y蓻z荜b蓾l蔀b蔁z蔂l散s桑s嗓s搔s骚s嫂s瑟s色s森s僧s莎s砂s沙s傻s啥s晇x煞s珊s苫s杉s山s煽s衫s闪s陕s擅s赡s膳s善s汕s晬z扇s商s赏s晌s上s尚s裳c梢s捎s稍s芍s勺s韶s少s哨s邵s奢s赊s蛇s舌s赦s射s涉s社s设s砷s申s呻s伸s身s深s娠s神s沈s暎y暔n甚s慎s生s甥s牲s蔃q暭h蔄m蔅y蔇j蔈b蔉g蔊h蔋d蔍l蔎s蔏s蔐d蔒h蔕d蔖c蔘s蔙x蔛h蔜a曌z曗y曻s蒌l蔠z蔢p蔤m茑n蔧h蔩y蔪j荫y蔮g蔯c蔰h蔱s蔲k蔳q枈p蔵z蔶z蔾l蔿w蕀j荨q蕂s蕄m蕅o蒇c蕇d蕋r蕌l蕍y荞q蕏z蕐h蕑j芸y蕔b莸y蕗l柛s荛r蕚e蕛t蕜f蕝j蕟f蕠r柨b蒉k蕣s蕥y蕦x蕧f柸b芜w蕫d蕬s萧x栭e蕯s蕰y蕱s蕳j蕵s蕶l蓣y蕸x桗d蕼s蕽n蕿x薀y薁y桜y省s盛c剩s失s施s诗s尸s虱s十s石d拾s什s梍z食s蚀s识s史s矢s使s屎s驶s始s式s示s士s世s梫q柿s事s拭s誓s逝s嗜s噬s适s棃l仕s侍s释s棇c饰s氏s市f恃s室s视s试s收s手s首s守s授s售s受s椃h瘦s蔬s梳s殊s抒s输s叔s舒s淑s椘c疏s赎s孰s熟s薯s暑s曙s署s蜀s黍s鼠s述s束s戍s竖s墅s庶s漱s薂x薃h楕t楖j楡y荟h薉h薋c芗x薍w薎m薐l薒c薓s薕l薖k榐z薗y薘d薙t薚t薝z薞s槀g薠f薡d薢x薣g薥s槁g薫x薬y薭b薱d槗q薲p薳y薴n薵c薶m薸p荠j薻z薼c薽z薾e薿n藀y藂c藃x藄q藅f藆j藇x藈k藊b藋d藌m荩j槸y藑q藒q藔l藖x藗s樐l藘l藙y藚x藛x艺y藞l藟l藠j藡d藢z藣b藦m藧h藨b薮s藫t藬t藭q藮q藯w藰l樼z樿s藲o藳g藴y藵b苈l藸z橩q恕s刷s耍s摔s衰c甩s栓s拴s霜s双s爽s谁s水s睡s吮s瞬s顺s舜s说s朔s斯s撕s嘶s思s私s司s死s肆s寺s嗣s四s似s饲s巳s松s颂s送s宋s讼s诵s搜s艘s嗽s酥s俗s素s檪l速s粟s僳s塑s溯s宿s诉s蒜s算s檾q櫈d櫐l虽s隋s随s髓s碎s穗s遂s隧s祟s櫢s梭s櫴l唆s索s锁s所s櫿y塌t他t她t欃c塔d蔺l欟g欦q藽q藾l歞e蘁w蘂r歬q殏q蕲q蘈t蘉m蕴y蘌y蘍x蘎j蘏j蘐x殭j毥x蘔j蘕p蘖n蘘r蘙y藓x蘛y蘜j蘝l蔹l蘟y蘠q蘡y茏l蘣t蘤h蘥y蘦l蘨y蘪m蘫l蘬g蘮j蘯d蘰k蘱l蘲l蘳h蘴f蘵z蘶w蘷k汦z汻h沕m蓠l蘻j蘽l蘾h虀j虁k泈z泘h虃j泿y虄s虅t洜l虇q虈x虉y虊l虋m虌b虒s虓x虖h虗x虘c虙f虚x虝h虠j浰l虡j虣b浲f虤y虥z虦z涖l涶t虩x虪s蹋t踏t胎t淃j抬t泰t酞t太t汰t坍t贪t檀t痰t潭t谭t谈t坦t毯t袒t碳t探t炭t渜n塘t搪t堂t棠t膛t唐t糖t倘c躺t淌t趟t掏t滔t萄t桃t逃t淘t陶t讨t套t特t腾t疼t誊t梯t湕j剔t踢t锑t提d题t蹄t啼t体t替t嚏t惕t涕t剃t湲y天t添t填t田t甜t恬t舔t腆t挑t眺t跳t贴t铁f帖t虭d虯q虰d虳j虴z虵s溳y滖s滜z滵m虸z蚃x蚄f漐z蚆b蚇c蚈q蚉w蚎y蚏y蚐j蚑q蚒t漹y潎p蚖y潣m蚗j蚘h蚙q蚚q蚛z蚞m蚟w蚡f蚢h蚥f蚦r蚫b澚a蚮d蚲p蚳c蚷j蚸l蚹f蚻z蚼g蚽p蚾p蛁d蛂b蛃b蛈t蛌t蛍y蛒g蛓c蛕h蛖m蛗f蛚l蛜y蛝x蛠l濵b蛡y蛢p蛣j濸c蛥s蛦y蛧w蛨m蛪q蛫g蛬q瀀y瀇w瀐j蛵x蛶j蛷q蛱j蜕t蛼c蛽b蛿h蜁x蜄s蜅f蚬x蜋l蜌b蜎y蜏y蜐j蜑d蜔d蜖h汀t廷t停t亭t庭t挺t艇t通t桐t酮t瞳t同t铜t彤t童t桶t灜y捅t筒t痛t偷t投t头t灩y透t凸t突t徒t途t屠t土t吐t兔t湍t推t颓t腿t褪t退t吞t屯t臀t拖t托t炏y鸵t陀t驮d炓l炗g驼t妥t拓t唾t挖w哇w蛙w娃w瓦w袜w炲t歪w外w豌w玩w顽w烷w完w碗w挽w晚w皖w惋w宛w烞p婉w腕w汪w王w烮l亡w枉w往w旺w望w忘w妄w威w蜙z蜛j蜝q蜟y蜠j蜤s蜦l蜧l蜨d蜪t蜫k蜬h蜭h蜯b蜰f蜲w蜳d蜵y蜶s蜸q蜹r蜺n蜼w蜽l蝀d蝁e蝂b蝃d蝄w蝅c焭q蝆y焲y蝋l蝍j蝏t焷p蝐m蝑x蝒m蝔j蝘y蝚r蝛w蝜f蝝y蝞m蝟w蝡r蝢x虾h蝧y蝨s蝩c蝪t蝫z蝬z蝭d蝯y蝱m蝲l蝳d蝵q蝷l蜗w蝹y蝺q蝿y螀j螁b蛳s螆c螇x螉w螊l螌b螎r螏j螑x螒h螔y螕b螖h螘y螙d螛h螜h螝g螠y螡w萤y螣t螤z巍w微w危w韦w违w桅w唯w惟w萎w委w尾w未w蔚w味w畏w胃w喂w魏w位w渭w谓w尉w慰w卫w瘟w蚊w文w燰w吻w紊w嗡w翁w爁l我w斡w握w沃w巫w钨w诬w屋w爗y爙r梧w吾w武w爠q五w捂w午w爥z舞w伍w侮w戊w雾w晤w物w勿w悟w误w昔x熙x析x西x硒x矽x晰x嘻x吸x牔b锡x螥c螦s螧q螩d螪s螮d螰l螱w螲d螴c螶q螷p螸y螹c蝼l螼q螾y螿j蟁w蟂x蟃w蛰z蟅z蝈g蟉l蟌c蟍l蟎m蟏x蟐c蟔m蟕z蟖s蟗q蟘t蟙z蟚p蟜j蟝q蟞b蟟l蟡g蟢x虮j蟤z蟦f蟧l蟨j蟩j蟫y狔n狚d蛲n猍l蟰x猏j蟱w蟳x蟴s蟵c蛏c蟷d蟸l蟺s蚁y蟼j蟽d蟿q蠀c蠁x蠂s蠄q蝇y虿c蠇l蠈z蠉x蠋z猽m蠌z蠍x蠎m蠏x蛴q蝾r蠒j蚝h獉z蠗z蠘j蠙b蠚h蠜f蠝l蠞j蠠m蛎l稀x息x希x悉x膝x夕x惜x熄x烯x溪x汐x犀x檄x袭x席x媳x喜x铣x洗x獹l隙x瞎x匣x霞x辖x暇x下x夏x掀x锨x先x仙x鲜x咸x贤x舷x闲x涎x嫌x显x险x腺x馅x陷x限x相x香x箱x襄x湘x乡x翔x祥x详x想x响x享x项x巷h橡x像x象x硝x霄x削x哮x销x消x宵x淆x蠤q蠥n蠦l蠧d蠨x蠩z蠪l蠫l蠬l蠭f蠮y蠯p蠰n蠳y蠴s蠵x瑊j瑘y蠸q瑦w瑸b璊m蠽j蠾z蠿z璠f衃p衆z衉k衋x衎k衏y衐q衑l衒x衕t衘x衦g衧y衪y甇y衱j衳z衴d衵r衶z衸j衺x衻r衼z袀j袃c袆h袇r畄l袉t袊l袌p袎y袏z袐b袑s袓j袔h袕x袗z袘y袙p畞m袚f畧l袝f袟z袠z袡r袣y袥t袦n袧g袨x袩z袪q小x孝x校j肖x疜x笑x效x楔x些x歇x疪b蝎x鞋x邪x斜x谐x械x卸x蟹x懈x痟x谢x屑x薪x痭b芯x锌x欣x辛x新x忻x心x信x衅x星x腥x猩x惺x刑x型x形x邢x行h醒x杏x性x姓x兄x胸x瘹d匈x雄x癁f熊x休x羞x朽x嗅x癊y锈x秀x袖x墟x戌q需x须x徐x许x蓄x酗x癦m旭x序x畜c絮n婿x轩x喧x宣x旋x玄x袬y袮m袯b袲c袳c袵r袶p袸j袹b袺j袻e袽r袿g裀y裃k裄h裇x裈k裋s裌j裍k裐j裑s裓g裖z裗l裚j裛y装z裞s裠q裦b裧c裩k裪t裫y裬l裭c裮c裯c裲l裵p裶f裷y裺y裻d制z裿y褀q褁g褃k褄q褅t褆t褈c褉x褋d褌k褍d褎x褏x褑y褔f褕y褖t褗y褘h褜p褝d褞y褟t褠g褢h褣r褤y褦n褧j褨s褩b褬s褭n褮y褯j褱h裢l褵l褷s选x眩x靴x薛x穴x雪x血x熏x循x旬x询x驯x巡x殉x汛x训x讯x逊x迅x押y鸦y鸭y丫y芽y牙y蚜y崖y衙y涯y雅y盶y讶y焉y阉y淹y盐y研y蜒y延y言y颜y阎y炎y沿y奄y掩y眼y衍y堰y燕y雁y唁y宴y谚y验y殃y央y鸯y秧y佯y羊y洋y氧y仰y养y漾y邀y腰y妖y褛l褹y褺d亵x褼x褽w褾b褿c襀j襃b襅q襆f襇j襈z襉j襊c襋j襌d襍z襎f襏b襑x襒b襓r襔m襕l襗z襘g襙c襚s襛n襜c裣l裆d襡s襢z襣b褴l襥f襧z襨t襩s襫s襭x襮b襰l襱l襳x襴l襵z襶d襷t襸z襹s襺j襼y襽l襾y覀y覂f覄f覅f覇b覉j瞈w覊j瞏q覌g覍b覎y瞔z覐j覑p覒m覔m覕p覗s觇c覙z覚j覛m覜t覝l覞y覟z覠j觋x遥y谣y姚y咬y舀y要y矊m耀y椰y噎y耶y野y冶y也y页y掖y腋y夜y液y一y壹y医y揖y铱y依y伊y衣y颐y夷y遗w移y胰y疑y沂y宜y姨y彝y椅y倚y已y乙y矣y以y抑y易y邑y屹g役y臆y逸y肄y疫y亦y裔y意y毅y益y溢y诣y议y谊y译y翼y翌y茵y因y音y阴y姻y吟y银y淫y寅y饮y尹y引y隐y覢s覣w覤x覥t觎y覧l矲b覨e覩d觊j覭m覮y觏g覰q覱z觐j観g覴d覵j覶l觑q覸j硡h硢y覻q覼l覾s觌d觃y觍t觕c觗z觘c觙j觛d觝d觟h觠q觡g觢s觤g觧j觨h觩q觪x觬n觭j觮j觰z觱b觲x觞s觵g觯z觷x觹x觺y觻l觼j觽x觾y觿x訁y訄q訅q訆j訉f訋d讧h訍c訏x讦j訑y訒r訔y讪s訙x訚y印y英y鹰y迎y赢y盈y影y硬y映y臃y庸y雍y踊y蛹y咏y碐l泳y永y恿y勇y用y幽y悠y尤y由y邮y铀y油y游y酉y碻q有y碽g友y磂l右y釉y诱y又y幼y迂y淤y于y盂y榆y虞y愚y舆y余y俞y逾y鱼y愉y渝y磭c隅y予y磰s雨y禹y宇y语y羽y玉y域y礃z芋y郁y遇y喻y峪y愈y育y誉y訞y訠s訡y讷n訦c訧y訨z訩x訫x訬c訮y訯s訰z訲y訳y訵c诃h訷s訸h訹x诊z注z证z訽g訿z詀z诂g詂f詃j詄d詅l诋d詇y詊p詋z詌g詍y讵j詏y诈z詑t诒y詓q诏z詖b礶g祍r祘s诎q詙b詚d诅z詜t詝z詟z诩x祱s詤h詥h祶d詧c詨x詪h诟g禈h诠q詯h诘j祯z詴w诜s詶c詷t詸m詻l诙h詽y詾x诖g誀e浴y寓y裕y预y豫y驭y鸳y冤y元y垣y袁y原y援y辕y猿y源y远y苑y愿y怨y院y曰y越y跃y钥y月y阅y耘y云y郧y陨y允y运y酝y韵y孕y匝z砸z杂z栽z哉z宰z载z再z在z赞z赃z葬z遭z糟z凿z藻z早z澡z蚤z躁z噪z造z皂z灶z燥z责z贼z怎z增z憎z曾c赠z喳c秢l渣z札z轧g誁b誂t誃y诔l诛z诓k誈w誋j志z誏l誐e诳k诶a誔t誖b誗c誙k诮q誛q誜s誝a誟x誢x诰g誧b誩j誫z説s読d誮h誯c誱j誳q誴c誵x谇s誷w誸x誺c誻t誾y諀p諁z谄c諃c谆z諅j諆j諈z诿w諊j諌d诤z諎z诹z諐q诼z諓j諔c諕x谂s諘b諙h諚b谀y諝x稬n谝p諟s諠x諡s诨h諣h稸x穉z铡z闸z眨z榨z咋z穙p乍z炸z摘z斋z穠n宅z窄z寨z瞻z詹z粘n沾z辗z展z蘸z站z湛z樟z章z彰z漳z掌z杖z丈z账z仗z瘴z障z招z昭z找z沼z赵z照z罩z兆z肇z召s遮z折s哲z辙z者z锗z蔗z这z浙z珍z斟z真z甄z砧z臻z贞z针z枕z疹z震z振z镇z阵z蒸z征z怔z整z拯z正z政z谔e諥z谛d諨f諩p諪t谏j諬q谕y谘z諯z諰x諲y谙a諴x諵n谌c诸z諹y諻h谖x窧z窽k谒y竌c竨d竪s诌z謆s謈b謉k謋h謌g謍y謏x竸j谧m謑x謒q謓c谑x謕t谡s謘c谥s謜y謞h謡y謢l謣y謤b謥c謧l谟m謩m謪s谪z謭j謮z謯j謰l謱l讴o謴g謵x謶z謷a謸a謺z謻y謼h謽j謿c譀h譂c譃x譄z譅s郑z芝z枝z支z吱z蜘z知z肢z脂z汁z之z直z植z殖s值z址z指z止z趾z旨z至z置z峙s智z秩z稚z质z炙z痔z治z窒z中z盅z筳t筴c忠z钟z衷z重c仲z舟z箈t周z州z洲z粥y轴z肘z帚z咒z宙z骤z珠z株z蛛z猪z逐z竹z煮z拄z主z著z柱z助z蛀z贮z铸z譆x譇z譈d譊n譋l譌e谲j譐z譑j譒b譓h譔z譕w谮z譗z谯q譛j譝s譞x譠t譡d譢s譣x譤j譥j譧z譨n譩y谵z譭h譮h譱s譲r譳r篒y譶t譸z譹h譺a譻y譼j譾j譿h讁z讂j讃z讄l讅s讆w讇c讉y讋z篻p讌y讍e雠c讏w讐c讑y讔y谶c讗x讘n讙h讛y谠d讝z谳y讟d讬t讱r讻x诇x诐b诪z谉s谞x住z祝z驻z抓z爪z拽z转z撰z赚z篆z撞z椎c锥z追z赘z捉z拙z卓z桌z琢z茁z酌z啄z着z灼z咨z资z姿z滋z淄z孜z紫z仔z籽z滓z自z字z鬃z棕z踪z宗z邹z走z奏z揍z租z足z卒c族z祖z阻z钻z纂z嘴z醉z最z罪z尊z遵z昨z左z佐z柞z做z作z坐z座z谸q谹h谺x谻j谼h谽h谾h谿x豀x豂l豃h豄d豅l豋d豍b豏x豑z豒z豓y籋n豖c豗h豘t豙y豛y豜j豝b豞h豟e豠c豣j豤k豥g豦j豧f豨x豩b豭j豮f豯x豰h豱w豲h豴d豵z豷y豻a豼p豽n豾p豿g貀n貁y貃m貄s貆h貇k貈h貋a貎n貏b貐y貑j貒t貕x貖y貗j貙c貚t貛h貜j粎m粓g貟y粡t貣d貤y貦w貭z亍c丌q兀w丐g廿n卅s丕p丞c鬲g孬n噩e丨g禺o丿p匕b乇z夭a爻y卮z氐d囟x胤y馗k毓y鼗t丶z亟j鼐n乜m亓q孛b嘏g厝c厥j靥y赝y匚f叵p糂s匾b赜z卦g卣y刂d刈y刎w刳k剌l糛t剞j剡s剜w蒯k剽p劂j劁q劐h劓y冂j罔w亻r仃d仉z仨s糿g仫m仞r仳p伢y佤w仵w伉k紤j佞n佧k攸y佚y佝g貮e贳s貱b赀z貵p貹s贶k絾c綛k綥q緛r繏x繑q繝j纄p纋y纕x纚l缿x翄c翭h翺a耛s聎t肒h肸x胋t胑z胻h脦t脺c脻j腟c臒w臤q臱m舋x舿k艕b芀t芁q芖z苚y茟y茰y莍q菻l萂h萿k葔h蔝m蔨j蔴m蕮x薆a莶x藱h藼x蘀t蘃r蘒q蘓s蘹h虂l虆l虨b虶y虷h蚅e蚔q蚭n蚿x蛯e蝖x螐w螚n蟭j蠷q蠺c衂n衭f袛d袾z襂s襐x覫p覹w觓q訤x詉n詗x詺m誎c誽n諽g諿x謃x謟t謲c譍y譪a譵d貥h乩j仡g斛h颢h銮l乊h乥h夫f兓j兙s兛q兝g兞h兣g兺b囻g坟f妢f婲h孒j尅k屗u岎f帉f幥z幩f弅f徚u怭b怾g慙c昐f晲n曢u朆f朌f朑u朩p枌f梤f乐l橨f檂n欂b毜c毮s洂y涜d颍y澵z炃f炍p炾h烪u焑y焺s燌f燓f燞u燢x獖f瓧s瓰f瓱m瓲t瓼l榛z彳c夔k璞p丟d並b丬p乂y乄s亙g亞y亠t亳b仝t伋j伕f伲n伽g佇z佈b佔z佗t佘s佟t佪h佴e併b佶j佻t佼j佾y侃k來l侉k侏z侑y侔m侖l侶l侷j俅q俎z俑y俚l俜p俟q俠x俳p俸f俾b倆l倉c個g倌g倏s們m倖x倜t倣f倥k倨j倩q倫l倬z倭w倮l偃y偈j偉w偌r偎w偕x側c偵z偺z偽w傖c傘s備b傢j傭y傳c傴y債z傷s傺c傾q僂l僅j僇l僉q僑q僕p僖x僥j僦j僬j僭j僮t僱g價j儀y儂n億y儅d儆j儇x儉j儋d儐b儔c儕c儘j優y儲c儷l儸l儺n儻t儼y兌d兒e兕s兗y內n兩l兮x冊c冑z冖m冢z冥m冪m冫b冱h冼x冽l凇s凈j凍d凫f凱k凵k凼d刖y別b刪s剄j則z剋k剎c剛g剝b剮g剴k創c剷c劃h劇j劉l劊g劌g劍j劑j劬q劭s劻k劾h勁j勐m動d勗x務w勛x勝s勞l勢s勣j勦j勰x勱m勵l勹b勻y匍p匏p匐f匭g匯h匱k區q協x卟b卩j卹x卻q厙s厭y厲l厴y厶s參c叟s叢c叨d叩k叱c叻l吆y吋c吒z吖y吡b吣q吲y吳w吶n呂l呃e呋f呎c呔d呤l呦y呱g呲c呶n呷g咂z咄d咔k咚d咝s咣g咤c咦y咧l咩m咪m咫z咭j咻x咼w咿y哂s哌p哏g哐k哚d哞m員y哧c哳z哽g哿g唄b唅h唏x唑z唔m唣z唧j唪f唰s唳l唷y唸n唼s唿h啁z啉l問w啐c啕t啖d啞y啟q啣x啵b啶d啷l啻c啾j喁y喃n喈j喋z喏n喑y喔o喙h喚h喟k喪s喫c喬q單d喱l喵m嗄a嗆q嗇s嗉s嗌y嗍s嗎m嗑k嗒d嗔c嗖s嗚w嗝g嗟j嗤c嗥h嗦s嗨h嗪q嗬h嗲d嗵t嗶b嗷a嗾s嘀d嘁q嘈c嘌p嘍l嘔o嘖z嘜m嘞l嘟d嘣b嘧m嘩h嘬c嘭p嘮l嘯x嘰j嘵x嘸f嘹l噁e噌c噍j噓x噔d噗p噘j噙q噠d噢o噤j噥n噦y噫a噯a噱j噲k噴p噸d噹d噻s噼p嚀n嚅r嚆h嚇h嚌j嚐c嚓c嚙n嚥y嚦l嚨l嚮x嚯h嚳k嚴y囀z囁n囂x囅c囈y囉l囌s囑z囔n囗w囝j囡n囪c囫h囹l囿y圄y圇l圉y圊q國g圍w園y圓y圖t圜h圩w圪g圮p圯y圳z圻q坂b坌b坨t坩g坫d坭n坰j坳a坶m坻c坼c垅l垌d垓g垠y垡f垤d垴n埏s埒l埕c埝n埡y埤p埭d埯a埴z執z埸y埽s堀k堅j堇j堊e堋b堍t堙y堞d堠h報b場c堿j塄l塊k塋y塍c塒s塗t塢w塤x塥g塬y塵c塹q塾s墀c墁m墉y墊d墑d墚l墜z墮d墻q壅y壇t壑h壓y壙k壚l壞h壟l壢l壩b壯z壺h壽s夂z夙s夠g夢m夤y夥h夼k夾j奐h奕y奘z奚x奧a奪d妁s妃f妍y妗j妝z妞n妣b妤y妯z妲d妳n妾q姊z姍s姒s姘p姝s姣j姦j姪z姹c娉p娌l娑s娓w娛y娣d娼c婀e婊b婕j婢b婦f婧j婭y婷t婺w媛y媧w媯g媲p媸c媼a媽m媾g嫖p嫗y嫘l嫜z嫠l嫣y嫦c嫫m嫵w嫻x嬈r嬉x嬌j嬖b嬗s嬙q嬝n嬡a嬤m嬰y嬲n嬴y嬸s孀s孃n孑j孓j孚f孢b孥n孫s孱c孳z學x孿l宀m宄g宓m宕d宥y宮g宸c寢q寤w實s寧n審s寫x寬k寮l寰h寵c寶b將j專z尋x對d尕g尜g尢w尥l尬g尷g尻k屄b屆j屐j屙e屜t屣x層c屬s屮c屺q岈y岌j岍q岐q岑c岙a岜b岡g岢k岣g岧t岫x岬j岱d岵h岷m峁m峋x峒d峴x島d峽x崆k崍l崗g崙l崛j崞g崠d崢z崤x崦y崧s崮g崴w崽z崾y嵇j嵊s嵋m嵒y嵩s嵫z嵬w嵯c嵴j嶁l嶂z嶄z嶇q嶗l嶙l嶷n嶸r嶺l嶼y嶽y巋k巑c巔d巖y巛c巰q巹j巽x帑t帔p帙z帥s帳z帶d帷w幃w幄w幔m幘z幛z幞f幟z幡f幣b幪m幫b幬c幹g幺y幾j庀p庂z庋g庖p庠x庥x庫k庳b庹t庾y廁c廂x廄j廈s廑q廒a廚c廛c廝s廡w廢f廣g廨x廩l廬l廱y廳t廴y廾g弁b弈y弋y弒s弔d弩n弭m弳j張z強q弼b彀g彆b彈d彊q彌m彎w彐x彖t彗h彘z彙h彡s彥y彫d彷f彿f徂c徇x徉y後h徑j徙x徜c從c徠l徨h復f徫w徬p徭y徵z徹c徼j忉d忐t忑t忒t忖c忝t忡c忤w忪s忭b忮z忸n怊c怍z怏y怙h怛d怡y怦p怩n怫f怵c恁n恂x恆h恙y恚h恝j恣z恥c恧n恪k悃k悅y悌t悒y悖b悚s悛q悝k悱f悴c悵c悶m悻x悽q惆c惘w惙c惝t惡e惱n惲y惴z惻c愀q愆q愍m愎b愕e愛a愜q愣l愨q愫s愴c愾k慄l慇y慊q態t慍y慘c慚c慝t慟t慣g慫s慮l慵y慶q慼q慾y憂y憊b憐l憑p憔q憚d憝d憧c憩q憫m憬j憲x憶y憷c懇k應y懋m懌y懍l懔l懞m懟d懣m懨y懲c懵m懶l懷h懺c懼j懾s懿y戀l戇g戉y戔j戕q戛j戟j戡k戢j戤g戥d戧q戩j戰z戲x戶h戽h戾l扃j扈h扌s扐c扠c扢g扺z抃b抆w抎y抴y抻c拊f拋p拗a拮j拶z挈q挲s挶j挹y挾x捃j捋l捨s捩l捫m捭b捱a捺n掃s掄l掊p掎j掙z掛g採c掬j掭t掮q掰b掾y揀j揄y揆k揎x揚y換h揞a揠y揲d揶y揸z揹b搆g搋c搌z損s搖y搗d搛j搟x搠s搡s搦n搴q搶q搿g摁e摑g摒b摜g摞l摟l摭z摯z摳k摶t摺z摻c撈l撓n撙z撚n撟j撣d撥b撫f撲p撻t撾z撿j擁y擄l擇z擊j擐h擔d擗p擘b據j擠j擢z擣d擤x擬n擯b擰n擱g擲z擴k擷x擺b擻s擼l擾r攄s攆n攉h攏l攔l攖y攙c攛c攜x攝s攢z攣l攤t攥z攬l攮n攴p攷k敉m敕c敗b敘x敫j敵d斂l斃b斐f斕l斫z斬z斷d於w旂q旃z旄m旆p旌j旎n旒l旖y旮g旯l旰g昀y昃z昇s昊h昕x昝z昱y昴m昶c晁c時s晉j晏y晗h晝z晞x晟c晡b晷g暄x暈y暉h暌k暘y暝m暨j暫z暱n暸l暹x暾t曄y曆l曇t曉x曖a曛x曜y曠k曩n曬s曷h書s會h朊r朐q朕z朦m朧l朮s杇w杈c杌w杓b杞q杪m東d杲g杳y杵c杷b杼z枇p枋f枘r枙e枰p枳z枵x枸g柁d柃l柘z柚y柝t柢d柩j柰n柵s栝g栩x栲k栳l桀j桁h桄g桉a桊j桎z桕j桫s桴f桷j桿g梃t梏g梓z梔z條t梟x梩q梵f棄q棖c棗z棟d棣d棧z棰c棲q棹z棼f椋l椏y椐j椴d椹s楂c楊y楓f楗j楝l楠n楣m楦x楨z楫j業y楮c楱c極j楸q楹y榀p榍x榕r榘j榙t榧f榪m榫s榭x榮r榱c榻t榿q槃p槊s槌c槍q槎c槓g槧q槨g槭q槲h槳j槿j樁z樂l樅c樑l樓l樗c樘t標b樞s樨x樵q樸p樹s樺h樽z樾y橄g橈r橋q橐t橘j橛j機j橢t橫h檁l檉c檎q檔d檗b檜g檠q檢j檫c檯t檳b檸n檻j櫓l櫚l櫛z櫝d櫟l櫥c櫧z櫨l櫪l櫬c櫳l櫸j櫺l櫻y欄l權q欏l欒l欖l欞l欷x欹q歃s歆x歎t歐o歙s歟y歡h歲s歷l歿m殂c殄t殍p殘c殞y殤s殪y殫d殮l殯b殲j殳s殺s殼k毀h毂g毆o毌g毪m毬q毳c毹s毽j毿s氅c氆p氈z氌l氍q氕p氘d氙x氚c氡d氣q氤y氪k氫q氬y氳y氵s氽c氾f汆c汊c汍w汎f汔q汜s汨m汩g汴b汶w決j沅y沆h沌d沐m沒m沓d沔m沖c沭s沱t沲t泐l泓h泔g泖m泗s泠l泫x泮p泯m泱y洄h洇y洌l洎j洙z洚j洧w洩x洫x洮t洳r洵x洶x洹h浜b浞z浠x浣h浬h浯w浹j浼m涇j涑s涓j涔c涫g涮s涼l涿z淅x淇q淒q淙c淚l淝f淞s淠p淥l淦g淨j淪l淵y淶l淼m渙h渚z減j渥w渦w渫x測c渲x渾h湄m湊c湎m湓p湔j湞z湟h湧y湫j湮y湯t溆x溏t準z溘k溝g溟m溥p溧l溫w溱q溲s溴x溷h溻t溼s溽r滂p滄c滅m滎x滏f滕t滟y滬h滯z滲s滷l滸h滹h滾g滿m漉l漕c漚o漢h漣l漤l漩x漪y漬z漭m漯l漲z漶h漸j漿j潁y潑p潔j潛q潟x潢h潤r潯x潰k潲s潴z潷b潸s潺c潼t澀s澆j澇l澉g澌s澍s澗j澠m澤d澧l澩x澮k澱d澶c澹d濂l濃n濉s濕s濘n濛m濞b濟j濠h濡r濤t濫l濮p濯z濰w濱b濺j濼l瀅y瀆d瀉x瀋s瀏l瀕b瀘l瀚h瀛y瀝l瀟x瀠y瀣x瀧l瀨l瀰m瀲l瀵f瀹y灃f灄s灑s灕l灘t灝h灞b灣w灤l灬h災z炅g炫x炱t為w炻s烀h烊y烏w焐w焓h無w焯c焱y煅d煉l煊x煒w煙y煜y煢q煦x煨w煩f煬y煲b煳h煸b煺t熒y熗q熘l熠y熨y熱r熳m熵s熹x熾c燁y燄y燉d燐l燒s燔f燙t營y燠y燦c燧s燬h燭z燮x燴h燹x燼j燾d爐l爛l爝j爨c爭z爰y爺y爾e爿p牆q牒d牖y牘d牝p牠t牦m牪y牮j牯g牴d牽q牿g犄j犍j犏p犒k犛l犟j犧x犭q犰q犴a犸m狀z狁y狃n狍p狎x狒f狨r狩s狳y狴b狷j狹x狺y狻s狽b猁l猊n猓g猗y猙z猝c猞s猢h猥w猬w猱n猶y猷y猸m猹c猻s獄y獅s獍j獐z獒a獗j獠l獨d獪k獫x獬x獯x獰n獲h獵l獷g獸s獺t獻x獼m獾h玀l玆z玎d玟m玢b玨j玳d玷d珀p珂k珈j珉m珙g珞l珥e珧y珩h珮p現x琊y琚j琛c琥h琦q琨k琪q琬w琮c琰y琺f琿h瑁m瑕x瑗y瑙n瑛y瑜y瑣s瑤y瑩y瑪m瑭t瑯l瑾j璀c璇x璉l璋z璐l璜h璣j璦a璧b璨c璩q璺w璽x瓊q瓏l瓖x瓚z瓞d瓠h瓴l瓿b甍m甏b甑z甓p甙d產c甦s甬y町d甾z畀b畈f畋t畎q畚b畛z畝m畫h畬s異y畹w畼c畿j疃t疊d疋y疒n疔d疝s疣y疬l疰z疳g疴k疸d疿f痂j痃x痄z痍y痖y痙j痣z痤c痦w痧s痲m痳m痼g痿w瘀y瘃z瘊h瘌l瘍y瘐y瘓h瘕j瘙s瘛c瘞y瘠j瘡c瘢b瘥c瘭b瘰l瘳c瘺l瘼m癀h療l癃l癆l癇x癍b癔y癖p癜d癟b癡c癢y癥z癩l癬x癭y癮y癯q癰y癱t癲d發f皈b皎j皓h皙x皚a皤f皰p皴c皸j皺z皻z盍h盜d盞z盡j監j盤p盥g盧l盪d盱x盹d眄m眇m眈d眍k眚s眢y眣d眥z眭s眵c眸m睇d睏k睚y睜z睞l睢s睥b睨n睪y睽k睿r瞀m瞌k瞍s瞑m瞞m瞟p瞠c瞢m瞭l瞰k瞵l瞼j瞽g瞿j矇m矍j矓l矚z矜j矧s矬c矯j矸g砉h砑y砘d砜f砝f砟z砣t砥d砩f砬l砭b砲p砹a砼t硃z硇n硌g硎x硐d硤x硨c硪w硭m硯y碇d碓d碚b碣j碥b碩s碲d碹x碼m磉s磔z磙g磚z磣c磧q磬q磯j磲q磴d礅d礎c礓j礙a礞m礤c礦k礪l礫l礱l礴b礻s祀s祅y祇q祉z祐y祓f祕m祗q祚z祛q祜h祠c祧t祺q祿l禊x禍h禎z禚z禦y禧x禮l禰m禱d禳r禿t秈x秕b秣m秫s秭z稂l稃f稅s稆l稈g稔r稜l稞k稟b種z稱c稷j稹z穀g穌s積j穢h穩w穫h穰r穸x穹q窀z窆b窈y窕t窠k窨x窩w窪w窬y窮q窯y窳y窶j窺k竄c竅q竊q竦s競j竺d竽y笄j笈j笊z笏h笙s笞c笠l笤t笥s笪d笫z笮z笱g笳j笸p笻q筆b筌q筍s筘k筠j筢p筮s筲s筵y筻g箄b箇g箋j箏z箐q箜k箝q箬r箴z箸z節j篁h範f築z篋q篌h篚f篝g篠x篤d篥l篦b篩s篪c篳b篼d篾m簀z簋g簌s簍l簏l簑s簟d簡j簣k簦d簪z簫x簷y簸b簽q簾l籀z籃l籌c籐t籜t籟l籠l籤q籥y籩b籪d籬l籮l籲y粑b粞x粢z粧z粲c粵y粼l粽z糅r糇h糈x糌z糍c糗q糝s糢m糧l糨j糰t糲l糴d糶t糸m糾j紀j紂z約y紅h紇h紈w紉r紋w納n紐n紓s紕p紗s紙z級j紜y紡f紮z細x紱f紲x紳s紹s紺g紼f紿d絀c終z絃x組z絆b絎h結j絛t絞j絡l絢x給g絨r統t絲s絳j絹j綁b綃x綆g綈t綏s綑k經j綜z綞d綠l綢c綣q綦q綬s維w綮q綰w綱g網w綴z綵c綸l綹l綺q綻z綾l綿m緇z緊j緋f緒x緗x緘j緙k線x緝j緞d締d緡m緣y緦s編b緩h緬m緯w緱g緲m練l緶b緹t緻z縈y縉j縊y縐z縑j縚t縛f縝z縞g縟r縣x縫f縭l縮s縯y縱z縳z縴q縵m縶z縷l縹p縻m總z績j繅s繆m繇y繈q繒z織z繕s繚l繞r繡x繢h繩s繪h繫x繭j繯h繰q繳j繹y繼j繾q纈x纊k續x纍l纏c纓y纔c纖x纘z纛d纜l纟s绔k绛j绱s缰j缶f缽b罄q罅x罈t罌y罘f罟g罡g罨y罰f罱l罵m罹l罾z羅l羆p羈j羋m羝d羧s義y羯j羰t羲x羸l羼c羿y翊y翎l習x翕x翡f翥z翦j翩p翮h翳y翹q耄m耆q耋d耑d耒l耔z耖c耜s耠h耢l耥t耦o耨n耩j耬l耱m耵d耷d聃d聆l聒g聞w聯l聰c聱a聲s聳s聵k聶n職z聹n聽t聾l聿y肅s肓h肜c肟w肫z肭n肱g肴y肷q肼j肽t胂s胍g胗z胛j胝z胥x胨d胩k胬n胭y胱g胲h胴d胼p脅x脈m脎s脒m脘w脛j脞c脣c脧j脩x脫t脬p脲n脹z腈j腌a腎s腓f腙z腚d腠c腡l腦n腧s腩n腫z腭e腱j腴y腸c腼m膂l膃w膈g膚f膠j膦l膪c膺y膻s膽d膾k膿n臁l臉l臊s臌g臍q臏b臚l臟z臠l臧z臨l臬n臾y舁y舂c舄x與y興x舉j舊j舐s舖p舛c舡c舢s舨b舫f舭b舯z舳z舴z舸g舺x舾x艄s艉w艋m艏s艚c艟c艣l艦j艨m艫l艮g艱j艴f艷y艸c艽j艿n芄w芊q芎x芏d芑q芘b芙f芟s芡q芤k芨j芩q芪q芫y芮r芰j芴w芷z芻c芾f苊e苒r苓l苕s苘q苜m苠m苡y苣j苤p苧n苴j苷g苻f茆m茇b茈c茉m茌c茍j茗m茚y茛g茜q茭j茯f茱z茲z茳j茴h茺c茼t荀x荃q荇x荊j荏r荑t荬m荸b荻d荼a荽s莊z莒j莓m莘s莛t莞g莠y莢j莧x莨l莩f莪e莰k莺y莼c菀w菁j菅j菔f菖c菘s菝b菟t菡h菥x華h菰g菸y菹z菽s萁q萃c萆b萊l萋q萏d萑h萘n萜t萬w萱x萵w萸y萼e葆b葉y葑f葙x葚r葜q葦w葩p葭j葯y葳w葶t葷h葸x葺q蒈k蒎p蒔s蒗l蒞l蒡b蒴s蒺j蒼c蒽e蒿h蓁z蓊w蓋g蓍s蓐r蓓b蓥y蓦m蓯c蓰x蓼l蓽b蔌s蔔b蔟c蔣j蔥c蔦n蔭y蔸d蔻k蕁q蕃f蕈x蕎q蕓y蕕y蕖q蕙h蕞z蕢k蕤r蕨j蕩d蕪w蕭x蕷y蕹w蕺j蕻h薅h薇w薈h薊j薌x薏y薑j薔q薜b薟x薤x薦j薧h薨h薩s薰x薷r薹t薺j藁g藍l藎j藜l藝y藥y藪s藶l藷s藹a藺l藿h蘄q蘅h蘆l蘇s蘊y蘋p蘗b蘚x蘢l蘧q蘩f蘭l蘺l蘼m蘿l虍h虔q處c虛x虜l號h虢g虧k虬q虺h虻m蚋r蚍p蚓y蚣g蚧j蚨f蚩c蚪d蚯q蚰y蚱z蚴y蚵k蚶h蚺r蛄g蛅z蛉l蛐q蛑m蛘y蛞k蛟j蛩q蛭z蛸s蛺j蛻t蜃s蜆x蜇z蜈w蜉f蜊l蜍c蜓t蜚f蜞q蜢m蜣q蜥x蜩t蜮y蜱p蜷q蜻q蜾g蜿w蝌k蝓y蝕s蝙b蝠f蝣y蝤q蝥m蝦x蝮f蝰k蝸w蝻n蝽c螂l螃p螅x螋s螓q螗t螞m螢y螨m螫s螬c螭c螯a螳t螵p螻l螽z蟀s蟄z蟆m蟈g蟊m蟋x蟑z蟒m蟓x蟠p蟥h蟪h蟬c蟮s蟯n蟲c蟶c蟻y蟾c蠃l蠅y蠆c蠊l蠐q蠑r蠓m蠔h蠖h蠛m蠟l蠡l蠣l蠱g蠲j蠹d蠼q衄n術s衛w衝c衢q衤y衩c衲n衹z衽r衾q衿j袂m袈j袞g袢p袤m袷q裊n裎c裏l裒p裘q補b裝z裟s裡l裥j裨b裰d裱b裼t製z裾j複f褊b褓b褙b褚c褡d褫c褰q褲k褳l褶z褻x襝l襞b襠d襤l襦r襪w襬b襯c襻p覃q見j規g覓m視s覘c覡x覦y親q覬j覯g覲j覷q覺j覽l覿d觖j觚g觜z觥g觫s觳h觴s觶z觸c訂d訃f訇h訊x訌h討t訐j訓x訕s訖q託t記j訛e訝y訢x訣j訪f設s許x訴s診z註z証z訾z詁g詆d詈l詎j詐z詒y詔z評p詘q詛z詞c詠y詡x詢x詣y詩s詫c詭g詮q話h該g詵s詼h誅z誆k誇k誌z認r誑k誕d誘y誚q語y誠c誡j誣w誤w誥g誨h誰s課k誶s誼y調d諂c諄z談t諉w請q諍z諏z諑z諒l論l諗s諛y諜d諞p諢h諤e諧x諫j諮z諱h諳a諶c諷f諸z諺y諾n謀m謁y謂w謅z謇j謊h謎m謐m謔x謗b謙q謚s講j謝x謠y謦q謨m謫z謬m謳o謹j譁h證z譎j譖z識s譙q譚t譜p譟z譫z譯y議y譴q護h譽y讀d讎c讒c讓r讕l讖c讚z谫j豇j豈q豉c豎s豐f豔y豕s豚t豬z豳b豸z貂d貅x貊m貍l貓m貔p貘m貝b負f財c貢g貧p貨h販f貪t貫g責z貯z貰s貲z貳e貴g貶b貸d貺k貼t貾c貿m賁b賂l賃l賄h賅g賆p資z賈j賉x賊z賋j賌g賎j賏y賐j賑z賒s賓b賔b賕q賖s賗c賘z賙z賛z賜c賝c賞s賟t賠p賡g賢x賣m賤j賥s賧d賨c賩c質z賬z賭d賮j賯x賰c賳z賴l賵f賶c賷j賸s賹y賺z賻f購g賽s賾z賿l贀y贂c贃w贄z贅z贆b贇y贈z贉d贊z贋y贌p贍s贎w贏y贐j贑g贒x贓z贔b贕d贗y贘s贙x贚l贛g贜z贠y贲b贻y贽z赅g赆j赇q赈z赉l赍j赑b赒z赓g赕d赗f赙f赟y赥x赧n赨t赩x赪c赬c赭z赮x赯t赱z赲l赳j赸s赹q赺y赻x赼z赽j赿c趂c趃d趄j趆d趇x趈z趉j趌j趍q趎c趏g趐x趑z趔l趖s趗c趘x趚s趜j趝j趞q趠c趡c趤d趥q趧t趨q趩c趪h趫q趭j趮z趯t趰e趱z趲z趵b趷k趹j趺f趻c趼j趽f趿t跁b跂q跄q跅t跆t跇y跈j跉l跍k跎t跏j跐c跒q跓z跔j跕d跖z跗f跘p跙j跚s跛b跜n跞l跠y跡j跢d跣x跤j跦z跧q跩z跫q跬k跭x跰p跱z跲j跴c跶d跷q跸b跹x跻j跼j跽j跾s跿t踀c踁j踂n踃x踄b踅x踆c踈s踉l踍q踎m踑j踒w踓w踔c踕j踗n踘j踙n踚l踛l踝h踟c踡j踣b踥q踦q踧c踫p踬z踭z踮d踯z踰y踱d踲d踳c踴y踵z踶d踷z踸c踹c踺j踻g踽j踾f踿c蹀d蹁p蹂r蹃n蹇j蹉c蹊q蹍n蹐j蹑n蹒p蹓l蹔z蹕b蹖c蹗l蹘l蹙c蹚t蹛d蹜s蹝x蹞k蹟j蹠z蹡q蹢d蹣p蹤z蹥l蹧z蹨n蹩b蹪t蹫j蹮x蹯f蹰c蹱z蹳b蹴c蹵c蹶g蹷j蹸l蹹t蹺q蹻q蹼p蹽l蹾d躀g躂d躃b躄b躅z躆j躈q躉d躊c躋j躍y躎n躏l躐l躑z躒l躓z躔c躕c躖d躗w躘l躙l躚x躛w躜z躝l躞x躟r躠s躡n躢t躣q躥c躦z躧x躨k躩j躭d躮s躰t躱d躵h躶l躷a躸j躹j躻w躽y躾x躿k軀q軁l軃d軄z軆t軇d軉y車c軋y軌g軎w軏y軐x軑d軒x軓f軔r軕s軖k軗s軘t軙c軚d軜n軝q軟r軠k軡q転z軣h軤h軥q軦k軧d軨l軩d軪a軫z軬f軮y軰b軱g軲g軴z軵r軶e軷b軹z軺y軻k軼y軽q軾s軿p輀e輁g輂j較j輄g輅l輆k輈z載z輋s輌l輍y輎s輏y輐w輓w輔f輕q輖z輗n輘l輙z輚z輛l輝h輞w輟c輡k輢y輣p輤q輥g輦n輨g輩b輫p輬l輭r輮r輰y輱x輲c輴c輵g輶y輷h輸s輹f輺z輻f輽f輾z輿y轀w轁t轂g轃z轄x轅y轆l轇j轈c轉z轊w轍z轎j轏z轐b轑l轔l轖s轗k轘h俁y係x轛d轝y轞j轟h轠l轡p轢l倀c轤l轥l轪d轫r轭e轱g轲k轳l轵z轶y轷h轸z轹l轺y轼s轾z辁q辂l辄z辇n辋w辌l辍c辏c辒w辔p辘l傑j辚l辝c辠z辡b辢l辥x辦b辪x辬b辮b辯b農n辳n辵c辶c辷y辸r辻s込y辿c迃y迆y迉q迊b迋w迌t迍z迏d儈k迕w迖d迗e迚d迤y迥j迨d迩e迬z迮z迯t迱y迲k迳j迴h迵d迺n迻y凜l迾l逄p逅h逇d逈j逋b逍x逎q逑q逓d逕j逖t這z逜w逡q連l逥h逦l逧g逨l逪c逬b逭h逯l週z進j逳y逴c逵k逶w逷t逹d逺y勸q遀s遄c遅c遈s遊y運y遌e過g遐x遑h遒q遖n遘g遙y遛l遜x遝t遞d遟c遠y遡s遢t遤h遦g遨a遪c遫c遯d遲c咴h遴l遶r遷q選x遹y遺y遻e遼l遽j遾s邁m邂x邃s還h邅z邆t邇e邈m邉b邊b邋l邌l邏l邒t邔q邕y邖s邘y邙m邛q邜x邝k邟k邠b邡f邥s邧y邬w邭j邰t邲b邳p邴b邶b邷w邸d邺y邼k邾z邿s喹k郀k郂g郃h郄q郅z郆j郇x郈h郉x郍n嗩s郏j郐k郒l郓y郔y郕c郖d郗x郘l郙f嘆t郚w郛f郜g郟j郠g嘗c郢y郤x郥b郦l郪q郫p郮z郯t郱p郳n郵y郶b郷x郹j郻q郾y郿m鄀r鄁b鄃s鄄j鄆y鄇h鄈k鄉x嚕l鄊x鄌t鄎x鄏r鄐c鄑z鄓y嚶y鄔w鄕x鄗h鄚m鄛c鄜f鄝l鄞y鄟z鄠h鄡q鄢y鄣z鄥q鄦x鄨b鄫z鄬w鄭z鄮m鄯s鄰l鄱p鄲d鄴y鄵c鄶k鄷f鄸m團t鄺k鄻l鄼z鄽c鄾y酀y酁c酂z酃l酄h酆f酇z酈l酊d酎z酏y酐g酑y酓y酔z酕m酖d酘d酙z酛k酜f酟t酠q酡t酢c酤g酦f垸y酧c酩m酫c酭y酯z酰x酲c酴t酹l酺p酻z堝g酾s醀w醁l醂l醃y醄t醅p醊z醌k醍t醎x醏d醐h醑x醕c醖y醗p醘k醙s醜c醝c醞y醟y醠a醡z醢h醣t醤j醥p醧y醨l醩z醪l醫y醬j醭b醮j醯x醰t醱p醲n醳y醴l醵j醶y醷y醸n醹r醺x醻c醼y醽l醾m醿m墼j釁x釃s釄m釅y壎x釆b壘l釐l釓g釖d奩l釘d釚q釛h針z釞z釟b釡f釣d釦k釧c釨z釩f釬h釭g釮q釰r釱d釲s釳x釴y釵c釶s釷t釸x釹n釺q釻q釼r釽p釾y鈀b鈁f鈂c鈅y鈆q嬋c鈉n鈊x鈋e鈌j鈍d嬪p孌l鈐q鈒s鈓r鈔c鈕n鈗y鈘y鈛g鈜h鈞j導d鈡z鈢x鈣g鈤r鈥h鈦t鈧k屝f鈫q鈬d鈭z鈮n鈯t鈰s鈲g鈳k鈴l屨j鈶s鈷g鈸b鈹p鈺y鈻s鈼z鈽b鉁z鉂s鉃s鉄t鉆z鉈t鉉x鉊z鉋b鉌h鉍b鉎s鉏c鉐s鉑b鉓c鉕p鉖t鉘f鉙z鉚m鉛q鉜f鉝l鉟p鉠y鉣j鉤g鉦z崳y鉨x鉩x鉪d鉫j鉭t鉮s嵐l鉯y鉰s鉱k鉶x鉷h鉸j鉹c鉺e鉻g鉼b嶝d鉿h嶧y銀y銂z巒l銄x銆m銇l銈j銉y銊x銋r銌z師s銎q銏s銒x銓q銔p銖z銙k銚d銛x銜x銝x銞j銟c銢p銥y銦y銧g銩d銪y銭q銯k銲h銳r銴s廟m銵k廠c銶q銷x銸z銺z銻t鋀t鋁l鋂m鋄w鋅x鋆y鋇b鋈w鋉s鋋c鋌t鋎h鋑j鋕z鋖s鋗x鋘h鋙w鋚t鋛k忄x鋞x鋟q鋠s鋡h鋢l鋣y鋤c鋥z鋦j鋧x鋨e鋩m鋪p鋬p鋭r鋮c鋯g鋰l鋳z鋴z鋵t惚h鋷z鋸j鋹c鋺y愷k鋼g鋽d鋿s錀l慪o錁k錂l錃p慳q憒k錅l憮w錇p錉m錊z錋p錌a錍p錎x錏y懸x錑l錒a錓k錕k錗n錘c錙z錚z錜n錞c錟t錠d錡q錢q錣z錤j錥y錦j錧g錨m錩c錪t捲j錬l錭d錮g錯c錱z録l錳m錴l錵h錷g錸l錹k錺k錻b揮h錼n錽w錾z錿h鍀d鍁x鍄l鍆m鍇k鍈y鍉c鍊l鍋g鍌x鍍d鍏w鍐z鍑f鍒r鍓j鍔e鍕j鍖c鍗t撐c鍘z鍙h鍚y撖h鍛d撘d撢d撳q擋d鍞k鍟s鍠h鍡w鍢f鍣z鍤c鍥q鍦s鍧h鍨k鍩n鍪m鍫q鍬q鍭h鍯c鍱y鍲m鍳j鍵j鍶s鍷k鍸h鍹x攪j鍺z鍻j鍼z鍽b鍾z鍿z鎀x鎁y鎂m鎃p鎄a鎅j鎆q鎇m鎈c鎉d鎊b攵p鎋x鎌l鎍s數s鎏l鎐y鎑y鎒n鎓w鎔r鎕t鎖s鎘g鎙s鎛b鎜p鎝d鎞b鎟s鎠g鎡z鎤h暢c鎦l鎧k鎨s鎩s鎪s鎫w鎬g鎭z鎮z鎯l鎰y鎱y鎲t鎳n鎴x鎵j鎶g鎷m鎸j鎹k鎺h鎻s鎼x鎽f鎾w鎿n鏀l鏁s鏂o鏃z鏄t鏅x鏆g鏇x鏈l鏉s鏊a鏋m鏌m鏍l鏎b鏏w鏐l鏑d鏒s鏔y鏕l鏖a鏗k鏘q鏙c鏚q鏛s鏝m鏞y鏟c鏠f鏡j鏢b鏣s鏤l鏥x枧j枴g柙x鏧l鏨z鏩j鏪c鏫l鏬x鏭x鏮k鏯s鏰b鏱z鏲q鏳z鏴l鏵h鏶j鏸h鏹q鏺p鏻l鏼s鏽x鏾s鏿c鐀g鐁s鐂l鐃n鐄h鐅p鐆s鐇f鐈q鐉q鐊x鐋t鐌x鐎j鐏z鐐l鐑q鐒l鐓d鐔x鐕z鐖j鐗j鐘z鐙d鐚y鐛y鐜d鐝j鐞n鐟z鐠p鐡t鐣c鐤d鐥s鐦k鐧j鐨f鐩s鐪l鐫j鐬h鐭y鐮l鐯z鐰q鐱j鐲z鐴b鐵t榦g鐷y鐸d鐹g鐻j鐽d鐾b鐿y鑀a構g鑁z鑂x槔g鑄z鑅h鑆z鑇j鑈n鑉h鑊h鑋q鑌b樣y鑎g鑏n鑐x鑑j鑒j鑓y鑔c鑕z鑖m鑗l鑘l檑l鑜s鑝p檣q鑞l鑟d鑠s鑡c鑢l鑣b鑤b鑥l鑦x鑧k鑨l鑩e櫃g鑪l鑫x鑬j櫞y鑮b鑯j鑰y鑱c鑲x鑳j鑴x鑵g鑷n鑸l鑹c鑺q鑻p鑼l鑽z鑾l鑿z钀n钁j欽q钃z钄l钅j钆g钇y钊z钋p钌l钍t钏c钐s钑s钔m钕n钖y钗c钚b钛t钜j钣b钤q钪k钫f钬h钭t钯b钰y钲z钴g钶k钷p钸b钹b钼m钽t铄s铈s铉x铊s铋b铌n铍p铎d铏x铐k铑l铒e铓m铔y铕y铖c铗j铘y铙n铚z铛c铞d铟y铠k铢z汙w铤d铥d铦x铧h铨q铩s铪h铫d铮z铯s铳c铴t铵a铷r铹l铻w铼l铽t铿k锂l锃z锆g锇e锉c锊l锍l锎k锏j況k锒l锓q锔j锕a锖q锘n锛b锜q锝d锞k锟k锠c锢g锧z锩j锪h锫p锬t锱z锲q锴k锵q锶s锷e锸c锺z锼s锽h锾h锿a镂l镃z镄f镅m镆m镈b镉g镋t镌j镎n镏l镒y镓j镔b镕r镖b镗t镘m镙l镚b镛y镝d镞z镟x镠l镡t镢j镤p淺q镥l镦d镧l镨p镩c镫d镬h镯z镱y镲c镳b镴l镵c長c镸c镹j溈w镻d镼j镽l門m閂s閃s閄h滌d閆y閇b閈h閉b閊c開k閌k閍b閎h閏r閐s閑x閒x漁y閔m閕x閖l閗d閘z閙n閚z閛p閜x閝l閞b閠r閡h関g閣g閤g閦c閧h閨g閩m閪s閫k閬l閭l閮t閰j閱y閲y潿w閳c閴q閶c閷s閸k閹y閺w閻y閼e閽h閾y閿w闀h闁b濁z闄y闅w闆b闈w闉y闊k闋q闌l闍d闎q闏p闐t濾l闓k瀾l闕q闖c闗g闘d闙q闚k闛t關g闝p闞k闟x闠h闡c闤h闥t闦w闩s闫y闬h闱w闳h闵m闶k闼t闾l闿k阃k阄j阆l阇d阈y阊c阋x阌w阍h阏e阒q阓h阕q阖h阗t阘t阙j阚k阛h阝f阞l阠x烴t阡q阢w阣y阤t阥y阦y阧d阨a阩s阪b阫p阬k阭y阯z阰p阱j阷c阸e阹q阺d阼z阽d阾l陁t陂b陃b陉x陊d煥h陎s陏d陑e陒g陓y陔g陖j陗q陘x陙c陚w陜x陝s陞s陟z陠p陣z陦d陧n陫f燈d燜m陭q陮d爍s陰y陱j陲c陳c陴p陸l陹s険x陻y陼z陽y陾r陿x隀c隁y隂y隃y隄d隇w隈w隉n隊d隌a牾w隍h階j隑g隒y隓h犋j隕y隖w隗k隚t際j犖l隝d隞a犢d隟x隠y隡s隢r隣l隤t隥d隦p隨s隩a險x隬n隭e隮j隯d隰x隱y隲z隴l隵x隷l隸l隹z隺h隻z隼s隽j隿y雂q雃j雈h雉z雊g雋j雎j雐h雑z雒l雓y雔c雖s雗h雘h雙s雚g雛c雜z雝y雞j雟g雡l離l難n雤y雥z雦c雧j雩y雫n雬f獎j雭s雮m雯w雰f雱p雲y雳l雴c雵y雸a獮x電d雼d雽h雿d霁j霂m霃c霅z霆t霈p霊l霋q霌z霎s霏f霐h霑z霒y霔s霕t霗l霘d霙y霚w霛l霝l霟h霠y霡m霢m霤l霥m霦b霧w霨w霩k霪y霫x霬y霭a霮d霯t霰s霱y霳l霴d霵j霶p霷y霺w霼x瑋w霽j霾m霿m靀m靁l靂l靃h靄a靅f靆d靇l靈l靉a靊f靋l靌b靍h靎h靏h靐b璁c靑q靓j靔t靕z靗c靘q靚j靜j靝t靟f靣m靤p靦m靧h靨y靪d靫c靬j靭r靮d靯d靰w靱r靲q靵n靷y環h靸s靹n靺m靻z靼d靽b靾x靿y鞀t鞁b瓔y鞂j鞃h鞄p鞅y鞆b鞇y鞈g鞉t鞊j鞌a鞎h鞏g鞐k鞑d鞒q鞓t甌o鞔m鞕b鞖s鞗t鞙x鞚k甕w鞛b鞜t鞝s鞞b鞟k鞡l鞢x鞣r鞤b鞥e鞦q鞧q鞨h鞩q鞪m鞫j鞬j鞮d鞯j鞰w鞱t鞲g鞳t鞴b鞵x畢b鞶p鞷g鞸b鞹k鞺t鞻l鞼g當d鞽q鞾x鞿j韀j疇c韂c韃d韅x韆q韇d韈w韉j韊l痠s韋w韌r韍f韎m韏q韐g韑w韒q韓h韔c韕k痺b韖r韗y韘s韙w韚g韛b韜t韝g瘋f韞y韟g韠b韡w韢s韣d韤w韥d韨f韪w韫y韬t韮j韯x韰x韱x韲j韴z韷l韸p韹h韺y韻y韼p韽a韾y響x頀h頁y頂d頃q項x癉d頇h須x頉y癘l頊x頋e頌s頍k頎q頏h癤j預y頑w頒b頓d頔d頕d頖p頗p領l頙c頚j頛l頜h頝q頞e頟e頠w頡j頢k頣s頤y頥y頦k頧d頨y頩p頪l頫f頬j頭t頮h頯k頰j頱l頲t頳c頴y頵j頶h頷h頸j頹t頺t頻b頼l頽t頾z頿z顀c顁d顂l顃t顄h顅q顆k顇c顈j顉q顊y顋s題t額e顎e顏y眙y顐w顒y顓z顔y顕x顖x顗y願y顙s顚d顛d顜j眾z顝k類l顟l顠p顡w顢m顣c顤y顥h顦q顧g顨x顩y顪h顫c顬r顭m顮b顯x顰p瞇m顱l顲l顳n顴q顸h顼x颀q颉j颋t颌g颎j颏k颒h颔h颕y颙y颚e颛z颞n颟m颡s颣l颥r颦p風f颩d颪g颫f颬x颭z颮b颯s颰b颱t颲l颳g颴x颵x颶j颷b颸s颹w颺y颻y颼s颽k颾s颿f飀l飁x飂l飃p飄p飅l飆b飇b飈b飉l飊b飋s飌f飍x飏y飐z飑b飒s飓j飔s飕s飖y砦z飗l飙b飚b飛f飜f飝f飡c飢j飣d飤s飥t飦z飧s飨x飩t飪r飫y飬y飭c飮y飯f飰f飱s碭d飲y飳z飴y飵z飶b飷j確q飸t飹b飺c飻t飼s飽b飾s飿d餀h餁r餂t餃j餄h餅b餆y餇t餈c餉x養y餋j餌e磽q餍y餎l餏x餑b餒n餓e餔b餕j餖d餗s餘y餙s餚y餛h餜g餝s餞j餟c餠b餡x餢b餣y餤d餥f餦z餧w館g餩e餪n餫y餬h餭h餮t餯h餰j餱h餲a餳x礬f餵w餶g餷c餸s餹t餺b餻g餼x餽k餾l餿s饀t饂w饃m饄t饅m饆b饇y饈x饉j饊s饋k饌z饍s饎x饏d饐y饑j饒r饔y饕t饖w饗x饘z饚h饛m饜y饝m饞c饟x饠l饡z饢n饣s饤d饦t饧x饨t禪s饩x饪r饫y饬c饳d饴y饷x饸h饹g饻x饽b饾d馀y馂j馃g馄h馇c馉g馊s馌y馎b馐x馑j馓s馔z馕n馘g馛b馜n馝b馞b馟t馠h馡f馢j馣a馤a馥f馦x馧y馨x穎y穡s馪p馫x馬m馭y馮f馯h馰d馱t馲t馳c馴x馵z馶z馷p馸x馹r馺s馻y馼w馽z馾d馿l駀y竇d駂b駃j筅x駅y駆q駇w駈q駉j駊p駋z駌y筧j駍p駎z駏j駐z駑n駒j駓p駔z駕j駖l駗z駘t駙f駚y駛s駜b駝t駞t駟s箢y駠l駡m駢p駣t駤z駥r駦t駧d駨x駩q駪s駫j駬e駭h駮b簞d駰y駱l駲z駳d駴h駵l駶j駷s駸q駹m駺l駻h駼t駽x駾t駿j騀e騁c騂x騃a騄l騅z騆z騇s騈p騉k騊t騋l騌z騍k騎q騏q騐y騑f騒s験y騔g騕y騖w騗p騙p騚q騛f紆y騜h騝q騞h騟y騠t騡q騢x騣z純c騥r騦s騧g騨t絕j騩g騪s騬c騭z騮l騯p騰t騱x騲c騳d騴y綽c緄g騶z騷s騸s騹q騺z騻s騼l騽x騾l騿z縋z驁a驂c驃p驄c驅q縲l驆b驇z驈y驉x驊h驋b驌s驍x驎l驏z驐d繃b驑l驒t驓c驔d驕j驖t驗y驘l驙z驚j驛y驜y繽b驝t驞p驟z驠y驡l驢l驣t驤x驥j驦s驧j驨x驩h驪l驫b驲r驵z驷s驸f驺z驽n驿y骀d骁x骃y骅h骈p骉b骊l骍x骎q骐q骒k骓z骔z骕s骖c骘z骙k罷b骛w骜a骝l骞q骟s骠b骢c骣c骥j骦s骧x骩w骪w骫w骬y骭g骮y骯a骰t骱j骲b骳b骴c骵t羨x骶d骷k骹q骺h骻k骼g骽t骾g骿p羻q髀b髁k髂q髃y髄s髅l髆b髇x髈b髉b髋k髌b髎l髏l聖s髐x髑d髒z體t髕b髖k髗l髙g髚q髛k髜q髝l髞s髟b髠k髡k髢d肀y髣f髤x髥r髦m髧d髩b髪f髫t髬p髭z髮f髯r髰t胙z髱b髲b髳m髴f髷q髸g髹x髺k髻j髽z髾s髿s鬀t鬁l膣z鬄t鬅p鬆s鬇z鬈q鬉z鬊s鬋j鬌d鬍h鬎l鬏j鬐q鬑l鬒z鬓b鬔p鬕m鬖s鬗m鬘m鬙s鬚x鬛l鬜q鬝q鬞n鬟h鬠k臘l鬡n鬢b鬣l鬤r鬥d臥w鬧n鬨h鬩x鬪d鬬d鬭d鬮j鬯c鬰y艙c鬳y艤y鬴f鬵z鬶g鬷z鬸l鬹g鬺s鬻y鬽m鬾j鬿q魀g魃b魅m魆x魇y芐h魉l魊y魋t魍w魎l魐g魑c魒p魕j魖x魗c魘y魙z魚y荮z莖j魜r魝j魞a魟h魠t魡d魢j魣x魤e魥j魦s魧h菪d菴a魩m萇c魪j魫s魬b魭y魮p魯l魰w葒h魲l魳z魴f魶n魷y魸n魹m魺h魻x魼q魽h魾p魿l鮀t蒹j蓀s鮂q鮃p鮄f鮅b鮆c鮇w鮈j鮉d蓮l鮊b鮋y鮌g鮍p鮎n鮏x鮐t鮑b蔆l鮒f鮓z鮔j鮕g鮖s蔞l蕆c蕘r鮘c鮙t鮚j鮛s鮜h鮝x鮞e鮟a鮠w鮡z鮢z鮣y鮤l鮥l鮦t鮧y鮨y鮩b鮪w鮫j鮬k鮭g鮮x鮯g鮰h鮱l鮲m鮳k鮴x鮵t鮶j鮷t鮸m鮹s鮺z鮻s鮼q鮽y鮾n鯀g鯁g鯂s鯃w鯄q鯅s鯆p鯇h鯈t蘞l鯊s鯋s鯌k鯍m鯎c鯏l虼g鯐s鯑k鯒y鯓s鯔z鯕q鯖q鯗x鯘n鯚j鯛d鯜q鯝g鯞z鯟d鯠l鯡f鯢n鯣y鯤k蜴y鯦j鯧c鯨j鯩l鯪l螄s螈y鯬l鯭m鯮z鯯z鯰n鯱x鯲d鯳s鯴s鯵s鯶h鯷t鯹x鯺z鯻l鯼z鯽j鯾b鯿b鰀h蟛p鰁q鰂z鰃w蟣j鰄w鰅y鰆c鰇r鰈d鰉h鰊l鰋y鰌q鰍q鰎j鰏b蠶c鰑y蠻m衊m鰓s鰔j鰕x鰖t鰗h鰘s鰙r鰚h鰛w鰜j鰝h鰞w鰟p鰠s鰡l鰢m鰣s鰤s鰥g鰦z鰧t鰨t鰩y鰪e鰫y鰬q鰭q鰮w鰯r鰰h鰱l鰲a袼g裉k鰴h鰵m鰶j鰷t鰸q鰹j鰺s鰻m鰼x鰽q鰿j鱀j鱁z鱂j鱃x鱄z鱅y鱆z鱇k鱈x襖a襲x鱊y鱋q鱌x鱍b鱎j鱏x鱐s鱑h鱒z覈h觀g觔j鱔s鱕f鱖g鱗l鱘x鱙y鱚x鱛a鱜k鱞g鱟h鱠k鱡z鱢s鱣z鱤g鱥g計j鱦y鱧l鱨c鱩h鱪s鱫a訟s訥n訶h鱭j鱮x鱯h鱰s鱱l鱲l鱳l鱴m鱵z鱶x鱷e鱸l鱹g鱺l鱻x鱽d鱾j試s鱿y鲀t鲂f詬g鲃b鲄h鲅b詰j鲆p鲇n詳x鲈l鲉y鲊z鲋f詿g鲌b鲎h誄l鲏p鲐t鲑g鲒j鲓k鲔w鲕e鲖t鲗z鲘h鲙k鲚j鲛j鲝z鲞x鲟x誦s鲠g鲡l說s鲢l鲣j鲥s鲦t誹f鲧g鲨s鲩h鲪j鲫j鲬y鲭q鲮l鲯q鲰z鲱f鲲k鲳c鲴g鲵n鲶n鲷d鲹s鲺s諦d鲻z鲼f諭y鲽d鲾b鲿c鳀t諼x謄t鳁w鳂w鳄e謖s鳅q鳆f謾m譏j鳇h鳈q鳉j鳊b變b鳌a鳍q鳎t鳏g鳐y鳑p讞y鳓l鳔b鳕x鳗m鳘m鳙y鳚w鳜g鳝s鳟z鳠h鳡g鳢l鳣z鳤g鳥n鳦y鳧f豊l鳨l鳪b鳫y鳬f鳭d鳮j鳯f鳰n鳱g鳲s鳳f鳴m鳵b鳶y貞z買m費f貽y鳸h賀h鳹q鳺f鳻b鳼w鳽j鳾s鳿y鴀f鴁y鴂j鴃j鴄p賍z鴅h鴆z鴇b鴈y鴉y鴊z鴋f鴌f賚l賦f賫l鴎o賱y鴏d賲b鴐j鴑r鴒l鴓m鴔f鴕t鴖m鴗l鴘b鴙z鴚g鴛y鴜c鴝q鴞x鴟c鴠d鴡j鴣g鴤z鴥y鴦y鴧y鴨y鴩d鴪y贖s鴬y鴭d赾q鴰g鴱a鴲z鴳y鴴h鴵x鴶j鴷l鴸z鴹y鴺y鴻h鴼l鴽r趒t鴾m鴿g趕g鵁j鵂x鵃z鵄c鵅l鵆q鵇t鵈e趛y鵊j鵋j趢l鵌t鵍h鵎t趦z趬q趶k鵐w鵒y鵓b鵔j鵕j跊m鵖b鵗x鵘j鵙j鵚t鵛j鵜t鵝e鵞e鵟k鵠h鵢s鵣l鵤z跮d鵦l鵧p鵨s鵩f鵪a鵫z鵬p踇m鵭q鵮q鵯b踋j鵰d鵱l鵲q踐j鵳j鵴j鵵t鵶y鵷y踖j鵸q鵹l鵺y鵻z鵼k鵽d踜l鵾k鵿s鶀q踠w鶁j鶂y踤z踨z踼t鶄j鶅z鶆l鶇d蹅c蹆t蹌q蹎d蹏t鶉c鶊g鶋j鶌q鶍y鶎k鶏j鶐s鶑y鶒c鶓m躌w躤j鶖q躪l鶗t鶘h鶙t鶚e躳g躴l躼l軂l軅y軈y軍j鶜m鶝f鶞c鶟t鶠y鶡h鶢y鶣p鶤k鶥m鶦h軛e鶧y軞m軭k軯p軳p鶩w鶪j軸z輇q鶬c鶭f鶮h鶯y鶰y鶱x鶲w輑y鶴h鶵c輜z鶶t鶷x鶸r輠g鶹l鶺j鶻g鶼j輧p輪l輯j輳c輼w鶾h鶿c鷀c鷁y鷂y轋h轌x轓f鷄j鷅l鷆t鷇k鷈t鷉t鷊y鷋t鷌m鷍x鷎g鷏t鷐c鷑j鷒t鷓z轙y鷔a轚j鷕y鷖y轜e鷗o鷘c鷙z鷚l鷛y轣l鷝b鷞s鷟z鷠y鷡w鷢j鷣y鷤t鷥s鷦j鷨h鷩b鷪y鷫s鷬h辀z鷮j辎z鷯l辤c鷱g辧b鷲j鷳x鷴x鷵t鷶m鷷z鷸y鷹y鷺l鷻t鷼x鷽x辭c鷿p鸀z鸁l鸂x鸃y鸄j鸅z鸆y鸇z辴z鸈y鸊p鸋n鸌h辺d鸍m鸎y鸏m鸐d鸑y迀g鸒y鸓l鸔b鸕l鸖h鸗l鸘s鸙y鸚y鸛g鸜q鸝l鸞l鸠j鸢y鸤s鸧c鸨b鸩z鸪g鸫d鸬l鸮x鸰l鸱c鸲q鸴x鸶s鸷z鸸e鸹g鸺x鸻h鸼z鸾l鹀w鹁b鹂l鹄g鹆y鹇x迒h鹈t迓y鹉w鹋m鹌a鹍k迠c鹎b迡c鹐q鹑c迣z迦j迧c鹓y鹔s迶y鹖h鹗e迼j鹘g迿x鹙q鹚c鹛m逌y逘y鹜w鹝y鹞y鹟w鹠l鹡j鹢y鹣j鹥y鹦y鹨l鹩l鹪j逤s鹫j逩b逫z逰y鹬y鹭l鹮h鹯z鹱h鹲m鹳g鹵l鹷l鹸j鹹x鹻j鹼j鹽y鹾c逽n逿d遃y遆t遉z麁c麂j麃b麄c麅p麆z麇j麈z麉j麊m麋b麌y麍l麎c麏j達d麐l違w麑n麒q麔j遚c麕j麖j麗l麘x麙x麚j麛m麜l麝s麞z麟l麠j麢l麣y麤c麥m麧h麨c麩f麪m麫m麬f麭p麮q麯q麰m麱f麲x麳l麴q麵m麶c麷f麸f麹q麺m適s麼m麽m遬s麾h麿m遰d黀z遱l黁n遳c黃h黅j黆g黇t黈t黉h黊h黋k黌h黏n黐c黒h黓y黕d黖x黗t黙m黚q黛d黜c黝y點d黟y黠x黡y黢q黣m黤y黥q黦y黧l黨d黩d黪c黫y邍y黬y邎y黭y黮d邐l黯a黰z黱d黲c黳y黴m黵d黶y黷d黸l黹z黻f黼f黽m邗h黾m黿y鼀c鼁q鼂c鼃w鼄z鼅z鼆m鼇a邞f鼊b鼋y邨c鼌c邩h鼍t邫b邽g鼑d鼒z鼔g鼕d鼘y鼙p鼚c鼛g鼜c鼝y鼞t鼟t鼡n鼢f鼣f鼤w鼥b鼦d鼧t郋x鼨z郌g鼩q鼪s鼫s鼬y鼭s鼮t鼯w鼰j鼱j鼲h鼳j鼴y鼵t鼶s鼷x鼸x郞l鼹y鼺l鼼y鼽q鼾h鼿w齀w齁h齂x齃e齄z齅x郣b郩x齆w齇z齈n齉n齊q郰z郲l齌j齍z齎j齏j齑j齒c齓c齔c齕h齖y齗y齘x郼y齚z齛x齜z齝c齞y齟j齠t齡l齢l齣c齤q齥x鄅y鄋s齧n齨j鄍m齪c齫y齬y齭c鄒z齯n鄖y鄘y鄤m齱z齲q齳y齴y鄧d鄩x鄪b齶e齷w齸y齹c齺z齻d齼c齾y龀c龁h龂y鄳m鄹z龃j龅b龆t龇z龈y龉y龊c龌w龍l龏g鄿q酅x龑y龒l龓l龔g龕k龗l龘d龛k龜g龝q酨z龞b龢h龣j龤x龥y鳩j鳷z鴍w鴢y鴫t鴮w鴯e鵀r鵉l鵏b鵑j鵡w鵥k鶃y鶛j鶨c鶫d鶳s鶽s鷃y鷜l鷧y鷭f鷰y鷾y鸉y鹒g鹕h鹶j鹺c麀y麡q鼈b鼉t鼏m齋z齙b齦y齮y齰z齵y齽j龎p龖d龡c癷b唉a苯b瞓f硸n秎f斗d稥x坊f竕f告g龟g哼h解j擂l罖r芈m羒f羘z羛y羜z羣q羦h羪y羫q羭y羮g羳f羵f羶s羷l翂f裂l聁u膹f艈u漂p骑q砌q雀q蒊h蒶f蕒m蕡f是s伺c毝c苔t虲u蚠f蝊u蟇m衁h衇m衈e衖x衚h衜d衞w衟d衠z衯f衮g袰b袴k呀y訜f子z豶f亂l傯z僨f償c兇x喲Y嗯E堯Y塏K墳F墾K鶕A鶔r鶈q鱬r鱝f魵f髍m馩f馚f饙f餴f颃h霻f霣y雺w隫f闧u闇a閥f閟b間j镪q钿d鐼f鐢f鏦c鏜t鍂p奮f婁l媵y屢l嶠j幀z幗g憤f錖d錆q銽x橥z歸g殛j炷z甯n瘧n瘵z碡z糞f紛f羥q腳j膩n臺t莜y蓿x褸l誒e讜d讠y贁b趀c趓d趙z趸d跀y跥d輊z輒z轒f轕g遧z邚r邤x郬q郺y酳y酼h酽y醆z醈t醓t醔q醦c釀n釂j釈s釋s釒j釔y釕l釗z釙p釠l釢n釤s釥q鉀j釪h釫h釯m釿j鈃x鈄d鈇f鈈b鈎g鈏y鈑b鈖f鈙q鈚p鈝y鈟d鈠y鈨y鈩h鈱m鈵b鈾y鈿d鉅j鉇s鉒z鉔z鉗q鉞y鉡b鉢b鉥s鉧m鉬m鉲k鉳b鉵t鉽s鉾m銁j銃c銅t銍z銐c銑x銕t銗h銘m銠l銡j銣r銤m銨a銫s銬k銰a銱d銹x銼c銾h銿z鋃l鋊y鋍b鋏j鋐h鋒f鋓c鋔w鋜z鋝l鋫l鋱t鋲b鋶l鋻j鋾t錄l錈j錐z錔t錛b錝c錫x錰s錶b鍃h鍅f鍎t鍜x鍝y鍮t鍰h鍴d鎎k鎗q鎚c鎢w鎣y鎥t鏓c鏷p鐍j鐳l鐶h鐺d鑃d鑍y鑙j鑚z鑛k鑭l鑶c钂t钘x铇b锳y镮h镺a镾m閁m閅m閯s閵l闂h闃g闑n闒t闔h闢p闣d陥x陬z陯l韁j韄h頄q順s顑k飠s饁y饓c駁b駄t駯z騘c騤k騫q騵y鰐e鰒f鰳l鰾p鱉b鱓s鳋s鳒j鳛x鹧z鹴s黂f黺f鼖f齩y驀m髊c髨k髵e髶e髼p鬂b鬦d鬫k鬱y魈x魌q魓b魛d魨t魱h鮁b鮗d鮿z鯙c鯉l鯥l鯫z鯸h龐p";
        #endregion

        #region CurrentMvcFunctionKey(当前MVC执行方法密匙)
        /// <summary>
        /// 当前MVC执行方法密匙
        /// </summary>
        public const string CurrentMvcFunctionKey = "JCE_MVC_FUNCTION_CURRENT";
        #endregion

        #region CurrentWebApiFunctionKey(当前WebApi执行方法密匙)
        /// <summary>
        /// 当前WebApi执行方法密匙
        /// </summary>
        public const string CurrentWebApiFunctionKey = "JCE_WEBAPI_FUNCTION_CURRENT";

        #endregion

        #region VerifyCodeSession(验证码缓存键)
        /// <summary>
        /// 验证码缓存键
        /// </summary>
        public const string VerifyCodeSession = "JCE_VERIFY_CODE_SESSION";

        #endregion

        #region DateFormat(日期格式化)
        /// <summary>
        /// 日期格式化
        /// </summary>
        public static class DateFormat
        {
            /// <summary>
            /// yyyyMMdd
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyyMMdd = "yyyyMMdd";

            /// <summary>
            /// yyyy-MM-dd
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyy_MM_dd = "yyyy-MM-dd";

            /// <summary>
            /// yyyyMMddHHmm
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyyMMddHHmm = "yyyyMMddHHmm";

            /// <summary>
            /// yyyy_MM_dd HH:mm
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyy_MM_dd__HH_mm = "yyyy_MM_dd HH:mm";

            /// <summary>
            /// yyyyMMddHHmmss
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyyMMddHHmmss = "yyyyMMddHHmmss";

            /// <summary>
            /// yyyy-MM-dd HH:mm:ss
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyy_MM_dd__HH_mm_ss = "yyyy-MM-dd HH:mm:ss";

            /// <summary>
            /// yyyyMMddHHmmssfffff
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public const string yyyyMMddHHmmssfffff = "yyyyMMddHHmmssfffff";
        }
        #endregion
    }
}

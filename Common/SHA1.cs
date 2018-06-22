using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Unreal.QCloud.Common
{
    class SHA1
    {
        public static string GetFileSHA1(Stream stream)
        {
            var strResult = "";
            var strHashData = "";
            byte[] arrbytHashValue;
            SHA1CryptoServiceProvider osha1 = new SHA1CryptoServiceProvider();
            stream.Seek(0, SeekOrigin.Begin);
            arrbytHashValue = osha1.ComputeHash(stream); //计算指定Stream 对象的哈希值
            //由以连字符分隔的十六进制对构成的String，其中每一对表示value 中对应的元素；例如“F-2C-4A”
            strHashData = BitConverter.ToString(arrbytHashValue);
            //替换-
            strHashData = strHashData.Replace("-", "");
            strResult = strHashData.ToLower();
            return strResult;
        }

    }
}

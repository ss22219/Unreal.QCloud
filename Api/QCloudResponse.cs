using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unreal.QCloud.Api
{
    public class QCloudResponse
    {
        public QCloudResponse() { }
        public QCloudResponse(int code, string message) {
            this.code = code;
            this.message = message;
        }

        public int code { get; set; }
        public string message { get; set; }
        public string access_url { get; set; }
        public string session { get; set; }
        public int slice_size { get; set; }
    }
}

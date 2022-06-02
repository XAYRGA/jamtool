using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Be.IO;

namespace jam
{
    public abstract class JAMBaseSerializable
    {
        [JsonIgnore]
        public int mBaseAddress;
        public abstract void WriteToStream(BeBinaryWriter writer);
    }
}

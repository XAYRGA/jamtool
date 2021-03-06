using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace jam.jaudio
{
    public class BARCProject
    {
        public const ulong BARCHeader = 0x2D2D2D2D42415243;

        public string ArcName;
        public int version;
        public BARCEntry[] entries;
    }

    public class BARCEntry
    {
        public string name;
        public uint u1;
        public uint u2;
        [JsonIgnore]
        public uint offset;
        [JsonIgnore]
        public uint size;
    }
}

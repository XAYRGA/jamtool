using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be.IO;

namespace jam.jaudio
{
    internal class WaveSystem
    {
        private const int WSYS = 0x57535953;
        public int id;
        public int total_sounds;

        WSYSScene[] Scenes; 
        WSYSGroup[] Groups; 

        private void loadFromStream(BeBinaryReader rd)
        {
            if (rd.ReadInt32() != WSYS)
                throw new InvalidDataException("Couldn't match WSYS header!");
            var size = rd.ReadInt32();
            id = rd.ReadInt32();
            total_sounds = rd.ReadInt32();

            var winfOffset = rd.ReadInt32();
            var wbctOffset = rd.ReadInt32();
            
        }       

    }

    public class WSYSScene
    {

        private const int SCNE = 0x53434E45;

        private const int C_DF = 0x432D4446;
        private const int C_EX = 0x432D4558;
        private const int C_ST = 0x432D5354;

        public WSYSWaveID[] DEFAULT;
        public WSYSWaveID[] EXTENDED;
        public WSYSWaveID[] STATIC;

        private WSYSWaveID[] loadContainer(BeBinaryReader rd, int type)
        {
            var inType = rd.ReadInt32();
            if (inType != type)
                throw new Exception($"Unexpected section type {type:X} != {inType:X}");
            var count = rd.ReadInt32();
            var waves = new WSYSWaveID[count];
            var offsets = util.readInt32Array(rd, count);
            for (int i=0; i < count; i++)
            {
                rd.BaseStream.Position = offsets[i];
                waves[i] = WSYSWaveID.CreateFromStream(rd);
            }
            return waves;
        }

        private void loadFromStream(BeBinaryReader rd)
        {
            if (rd.ReadInt32() != SCNE)
                throw new Exception("SCNE corrupt");
            rd.ReadUInt64(); // Padding? Something???? Always zero.
            var cdfOffset = rd.ReadInt32();
            var cexOffset = rd.ReadInt32();
            var cstOffset = rd.ReadInt32();

            rd.BaseStream.Position = cdfOffset;
            DEFAULT = loadContainer(rd, C_DF);
            rd.BaseStream.Position = cexOffset;
            EXTENDED = loadContainer(rd, C_EX);
            rd.BaseStream.Position = cstOffset;
            STATIC = loadContainer(rd, C_ST);
        }
    }

    public class WSYSGroup
    {
        public string awPath;
        public WSYSWave[] waves;    
    }

    public class WSYSWaveID
    {
        public short GroupID; 
        public short WaveID;
        
        public void loadFromStream(BeBinaryReader rd)
        {
            GroupID = rd.ReadInt16();
            WaveID = rd.ReadInt16();
        }
        public static WSYSWaveID CreateFromStream(BeBinaryReader rd)
        {
            var b = new WSYSWaveID();
            b.loadFromStream(rd);
            return b;
        }
    }
    

    public class WSYSWave
    {
        public ushort format;
        public ushort key;
        public double sampleRate;
        public int sampleCount;

        public int aw_start;
        public int aw_size;

        public bool loop;
        public int loop_start;
        public int loop_end;

        public int last;
        public int penult;
    }
}


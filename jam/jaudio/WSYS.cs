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
        private const int WINF = 0x57494E46;
        private const int WBCT = 0x57424354;
        public int id;
        public int total_sounds;

        public WSYSScene[] Scenes; 
        public WSYSGroup[] Groups; 


        private void loadWinf(BeBinaryReader rd)
        {
            if (rd.ReadInt32() != WINF)
                throw new Exception("WINF corrupt");
            var count = rd.ReadInt32();
            var ptrs = util.readInt32Array(rd, count);
            Groups = new WSYSGroup[count];
            for (int i=0; i < count; i++)
            {
                rd.BaseStream.Position = ptrs[i];
                Groups[i] = WSYSGroup.CreateFromStream(rd);
            }
        }

        private void loadWbct(BeBinaryReader rd)
        {
            if (rd.ReadInt32() != WBCT)
                throw new Exception("WBCT corrupt");
            rd.ReadInt32(); // Empty?
            var count = rd.ReadInt32();
            var ptrs = util.readInt32Array(rd, count);
            Groups = new WSYSGroup[count];
            for (int i = 0; i < count; i++)
            {
                rd.BaseStream.Position = ptrs[i];
                Groups[i] = WSYSGroup.CreateFromStream(rd);
            }
        }

        public static WaveSystem CreateFromStream(BeBinaryReader rd)
        {
            var b = new WaveSystem();
            b.loadFromStream(rd);
            return b;
        }

        private void loadFromStream(BeBinaryReader rd)
        {
            if (rd.ReadInt32() != WSYS)
                throw new InvalidDataException("Couldn't match WSYS header!");
            var size = rd.ReadInt32();
            id = rd.ReadInt32();
            total_sounds = rd.ReadInt32();

            var winfOffset = rd.ReadInt32();
            var wbctOffset = rd.ReadInt32();

            rd.BaseStream.Position = winfOffset;
            loadWinf(rd);

            rd.BaseStream.Position = wbctOffset;
            loadWbct(rd);
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

        public static WSYSScene CreateFromStream(BeBinaryReader rd)
        {
            var b = new WSYSScene();
            b.loadFromStream(rd);
            return b;
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

        public void WriteToStream(BeBinaryWriter wr)
        {
        
        }
    }

    public class WSYSGroup : JAMBaseSerializable
    {
        public string awPath;
        public WSYSWave[] waves;

        public static WSYSGroup CreateFromStream(BeBinaryReader rd)
        {
            var b = new WSYSGroup();
            b.loadFromStream(rd);
            return b;
        }

        private void loadFromStream(BeBinaryReader rd)
        {
            awPath = "";
            var stringBuff = rd.ReadBytes(0x70);
            for (int i = 0; i < 0x70; i++)
                if (stringBuff[i] != 0)
                    awPath += (char)stringBuff[i];
                else
                    break;
            
            var count = rd.ReadInt32();
            var ptrs = util.readInt32Array(rd, count);
            waves = new WSYSWave[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                rd.BaseStream.Position = ptrs[i];
                waves[i] = WSYSWave.CreateFromStream(rd);
            }
        }

        public override void WriteToStream(BeBinaryWriter wr)
        {
            mBaseAddress = (int)wr.BaseStream.Position;
            byte[] buff = new byte[0x70];
            for (int i=0; i < awPath.Length; i++)
                buff[i] = (byte)awPath[i];
            wr.Write(buff);
            wr.Write(waves.Length);
            var retBase = wr.BaseStream.Position;

            for (int i = 0; i < waves.Length; i++)
                wr.Write(0xDEADBEEF);

            for (int i = 0; i < waves.Length; i++)
                waves[i].WriteToStream(wr);

            var endRet = wr.BaseStream.Position;
            wr.BaseStream.Position = retBase;

            for (int i = 0; i < waves.Length; i++)
                wr.Write(waves[i].mBaseAddress);

            wr.BaseStream.Position = endRet;
        }
    }


    public class WSYSWaveID : JAMBaseSerializable
    {
        public short GroupID; 
        public short WaveID;
        
        public void loadFromStream(BeBinaryReader rd)
        {
            GroupID = rd.ReadInt16();
            WaveID = rd.ReadInt16();
            rd.ReadInt32(); // CCCCCCCC
            rd.ReadInt32(); // FFFFFFFF
        }
        public static WSYSWaveID CreateFromStream(BeBinaryReader rd)
        {
            var b = new WSYSWaveID();
            b.loadFromStream(rd);
            return b;
        }

        public override void WriteToStream(BeBinaryWriter wr)
        {
            mBaseAddress = (int)wr.BaseStream.Position;
            wr.Write(GroupID);
            wr.Write(WaveID);
            wr.Write(0xCCCCCCCC); // Uninitialized stack
            wr.Write(0xFFFFFFFF); // nice
        }
    }
    

    public class WSYSWave : JAMBaseSerializable
    {
        public ushort format;
        public ushort key;
        public double sampleRate;
        public int sampleCount;

        public int awOffset;
        public int awLength;

        public bool loop;
        public int loop_start;
        public int loop_end;

        public short last;
        public short penult;


        public void loadFromStream(BeBinaryReader rd)
        {
            rd.ReadByte(); // Empty.
            format = rd.ReadByte();
            key = rd.ReadByte();
            rd.ReadByte(); // empty. 
            sampleRate = rd.ReadSingle();
            awOffset = rd.ReadInt32();
            awLength = rd.ReadInt32();
            loop = rd.ReadInt32() > 0;
            loop_start = rd.ReadInt32();
            loop_end = rd.ReadInt32();
            last = rd.ReadInt16();
            penult = rd.ReadInt16();
            rd.ReadInt32(); // Zero.
            rd.ReadInt32(); // 0xCCCCCCCC Uninitialized stack
        }
        public static WSYSWave CreateFromStream(BeBinaryReader rd)
        {
            var b = new WSYSWave();
            b.loadFromStream(rd);
            return b;
        }

        public override void WriteToStream(BeBinaryWriter wr)
        {
            mBaseAddress = (int)wr.BaseStream.Position;
            wr.Write((byte)0xCC);
            wr.Write(format);
            wr.Write(key);
            wr.Write((byte)0);
            wr.Write(sampleRate);
            wr.Write(awOffset);
            wr.Write(awLength);
            wr.Write(loop ? 0xFFFFFFFF : 0);
            wr.Write(loop_start);
            wr.Write(loop_end);
            wr.Write(last);
            wr.Write(penult);
            wr.Write(0);
            wr.Write(0xCCCCCCCC);
        }

    }
}


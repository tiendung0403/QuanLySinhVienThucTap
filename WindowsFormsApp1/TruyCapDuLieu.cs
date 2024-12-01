﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class TruyCapDuLieu
    {
        private static TruyCapDuLieu instanse = null;
        private List<LoaiDeTai> dsLoaiDeTai;

        private TruyCapDuLieu()
        {
            dsLoaiDeTai = new List<LoaiDeTai>();
        }

        public static TruyCapDuLieu khoitao()
        {
            if(instanse == null)
                instanse = new TruyCapDuLieu();
            return instanse;
        }

        public List<LoaiDeTai> getDanhSachLoaiDT()
        {
            return dsLoaiDeTai;
        }

        public static bool docFile(string tenFile)
        {
            try
            {
                using (FileStream fs = new FileStream(tenFile, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    instanse = (TruyCapDuLieu)bf.Deserialize(fs);
                }
                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ghiFile(string tenFile)
        {
            try
            {
                using (FileStream fs = new FileStream(tenFile, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, instanse);
                }
                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
namespace Seriport_alistirma
{
    public class BaglantiSinif
    {
        public string Adres = System.IO.File.ReadAllText(Application.StartupPath + @"\Connection.txt");
    }
}

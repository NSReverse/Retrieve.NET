﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_net_II.Sources.Model
{
    public class PlaylistInfo
    {
        public String UUID = Guid.NewGuid().ToString();
        public String name;
        public HashSet<String> idSet = new HashSet<string>();
    }
}

﻿using GameServer.Database;
using GameServer.Model.Character;
using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Network.Recv
{
    public class RequestCharacterList : ARecvPacket
    {
        protected internal override void Read()
        {
            
        }

        protected internal override void Run()
        {
            CharacterService.GetInstance().SendCharacterList(_Client._Account);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySoftware.utils;
using LibrarySoftware.data;

namespace LibrarySoftware.network.packets
{
    [Serializable]
    class BookPacket : IPacket
    {
        public Book book { get; set; }

        public BookPacket(Book book)
        {
            this.book = book;
        }

        public int getPacketID()
        {
            return Registry.packet_bookData;
        }
    }
}

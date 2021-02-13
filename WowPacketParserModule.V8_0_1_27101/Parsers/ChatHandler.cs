﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.V8_0_1_27101.Parsers
{
    public static class ChatHandler
    {
        [Parser(Opcode.SMSG_CHAT)]
        public static void HandleServerChatMessage(Packet packet)
        {
            var text = new CreatureText
            {
                Type = (ChatMessageType)packet.ReadByteE<ChatMessageTypeNew>("SlashCmd"),
                Language = packet.ReadUInt32E<Language>("Language"),
                SenderGUID = packet.ReadPackedGuid128("SenderGUID")
            };

            packet.ReadPackedGuid128("SenderGuildGUID");
            packet.ReadPackedGuid128("WowAccountGUID");
            text.ReceiverGUID = packet.ReadPackedGuid128("TargetGUID");
            packet.ReadUInt32_Sanitize("TargetVirtualAddress");
            packet.ReadUInt32_Sanitize("SenderVirtualAddress");
            packet.ReadPackedGuid128("PartyGUID");
            packet.ReadInt32("AchievementID");
            packet.ReadSingle("DisplayTime");

            var senderNameLen = packet.ReadBits(11);
            var receiverNameLen = packet.ReadBits(11);
            var prefixLen = packet.ReadBits(5);
            uint channelLen = 0;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V8_1_0_28724))
                channelLen = packet.ReadBits(8);
            else
                channelLen = packet.ReadBits(7);
            var textLen = packet.ReadBits(12);
            packet.ReadBits("ChatFlags", 11);

            packet.ReadBit("HideChatLog");
            packet.ReadBit("FakeSenderName");
            bool unk801bit = packet.ReadBit("Unk801_Bit");

            text.SenderName = packet.ReadWoWString_Sanitize("Sender Name", senderNameLen);
            text.ReceiverName = packet.ReadWoWString_Sanitize("Receiver Name", receiverNameLen);

            uint entry = 0;
            if (text.SenderGUID.GetObjectType() == ObjectType.Unit)
                entry = text.SenderGUID.GetEntry();
            else if (text.ReceiverGUID.GetObjectType() == ObjectType.Unit)
                entry = text.ReceiverGUID.GetEntry();

            packet.ReadWoWString("Addon Message Prefix", prefixLen);
            packet.ReadWoWString("Channel Name", channelLen);

            if (entry != 0)
                text.Text = packet.ReadWoWString("Text", textLen);
            else
                text.Text = packet.ReadWoWString_Sanitize("Text", textLen);

            if (unk801bit)
                packet.ReadUInt32("Unk801");

            if (entry != 0)
                Storage.CreatureTexts.Add(entry, text, packet.TimeSpan);
        }

        [Parser(Opcode.CMSG_CHAT_ADDON_MESSAGE, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleAddonMessage(Packet packet)
        {
            var prefixLen = packet.ReadBits(5);
            var testLen = packet.ReadBits(8);
            packet.ReadBit("IsLogged");
            packet.ResetBitReader();

            packet.ReadInt32("Type");
            packet.ReadWoWString_Sanitize("Prefix", prefixLen);
            packet.ReadWoWString_Sanitize("Text", testLen);
        }

        [Parser(Opcode.CMSG_CHAT_ADDON_MESSAGE, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleAddonMessage810(Packet packet)
        {
            var prefixLen = packet.ReadBits(5);
            var testLen = packet.ReadBits(9);
            packet.ReadBit("IsLogged");
            packet.ResetBitReader();

            packet.ReadInt32("Type");
            packet.ReadWoWString_Sanitize("Prefix", prefixLen);
            packet.ReadWoWString_Sanitize("Text", testLen);
        }
    }
}

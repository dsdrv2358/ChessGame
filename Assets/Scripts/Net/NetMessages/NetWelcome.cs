using Unity.Collections;
using UnityEngine;

public class NetWelcome : NetMessage
{
    public NetWelcome()
    {
        Code = OpCode.WELCOME;
    }
    public NetWelcome(DataStreamReader reader)
    {
        Code = OpCode.WELCOME;
        Deserialize(reader);
    }
}

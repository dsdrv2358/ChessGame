using Unity.Collections;
using Unity.Networking.Transport;

public class NetMakeMove : NetMessage
{
    public NetMakeMove() // <-- Making the box
    {
        Code = OpCode.MAKE_MOVE;
    }
    public NetMakeMove(DataStreamReader reader) // <-- Receiving the box
    {
        Code = OpCode.MAKE_MOVE;
        Deserialize(reader);
    }

    public override void Serialize(ref DataStreamWriter writer)
    {
        writer.WriteByte((byte)Code);
    }
    public override void Deserialize(DataStreamReader reader)
    {

    }

    public override void ReceivedOnClient()
    {
        NetUtility.C_MAKE_MOVE?.Invoke(this);
    }
    public override void ReceivedOnServer(NetworkConnection cnn)
    {
        NetUtility.S_MAKE_MOVE?.Invoke(this, cnn);
    }
}

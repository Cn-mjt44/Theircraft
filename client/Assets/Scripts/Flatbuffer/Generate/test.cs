// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::FlatBuffers;

public struct Test : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Test GetRootAsTest(ByteBuffer _bb) { return GetRootAsTest(_bb, new Test()); }
  public static Test GetRootAsTest(ByteBuffer _bb, Test obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Test __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Test_Item? List(int j) { int o = __p.__offset(4); return o != 0 ? (Test_Item?)(new Test_Item()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Test> CreateTest(FlatBufferBuilder builder,
      VectorOffset listOffset = default(VectorOffset)) {
    builder.StartObject(1);
    Test.AddList(builder, listOffset);
    return Test.EndTest(builder);
  }

  public static void StartTest(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset) { builder.AddOffset(0, listOffset.Value, 0); }
  public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<Test_Item>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, Offset<Test_Item>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Test> EndTest(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Test>(o);
  }
  public static void FinishTestBuffer(FlatBufferBuilder builder, Offset<Test> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTestBuffer(FlatBufferBuilder builder, Offset<Test> offset) { builder.FinishSizePrefixed(offset.Value); }
};


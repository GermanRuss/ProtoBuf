﻿// Classes and structures being serialized

// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
// To make custom modifications, edit the .proto file and add //:external before the message line
// then write the code and the changes in a separate file.
using System;
using System.Collections.Generic;
using SilentOrbit.ProtocolBuffers;
using TestNew;

namespace UnityEngine
{
    // Written elsewhere
    // public struct Vector3 {}

}
namespace Despunch.Data
{
    public partial class Link : IDisposable, Pool.IPooled, IProto
    {
        public UnityEngine.Vector3 pos;

    }

    public partial class Building : IDisposable, Pool.IPooled, IProto
    {
        public List<Despunch.Data.Link> links;

        public UnityEngine.Vector3 pos;

    }

    public partial class InputState : IDisposable, Pool.IPooled, IProto
    {
        public int buttons;

        public UnityEngine.Vector3 aimAngles;

        public UnityEngine.Vector3 mouseDelta;

    }

}
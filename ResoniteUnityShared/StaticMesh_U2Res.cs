
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Float2_U2Res
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Float3_U2Res
    {
        public float x;
        public float y;
        public float z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Float4_U2Res
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4x4_U2Res
    {
        public float m00;

        public float m01;

        public float m02;

        public float m03;

        public float m10;

        public float m11;

        public float m12;

        public float m13;

        public float m20;

        public float m21;

        public float m22;

        public float m23;

        public float m30;

        public float m31;

        public float m32;

        public float m33;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UVArray_U2Res
    {
        public int dimension;
        public Float2_U2Res[] uv_2D;
        public Float3_U2Res[] uv_3D;
        public Float4_U2Res[] uv_4D;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TriSubmesh_U2Res
    {
        public int[] indicies;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct BlendShapeFrame_U2Res
    {
        public float frameWeight;
        public Float3_U2Res[] positions;
        public Float3_U2Res[] normals;
        public Float3_U2Res[] tangents;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BlendShape_U2Res
    {
        public string name;
        public BlendShapeFrame_U2Res[] frames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BoneBinding_U2Res
    {
        public int boneIndex0;
        public float weight0;
        public int boneIndex1;
        public float weight1;
        public int boneIndex2;
        public float weight2;
        public int boneIndex3;
        public float weight3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Bone_U2Res
    {
        public string name;
        public Matrix4x4_U2Res bindPose;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct StaticMeshImportSettings_U2Res
    {
        public bool reverse;
        public bool makeDualSided;
        public bool makeFlatShaded;
        public bool calculateTangents;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct StaticMesh_U2Res
    {
        public string name;
        public StaticMeshImportSettings_U2Res importSettings;
        public Float3_U2Res[] positions;
        public Float4_U2Res[] colors;
        public Float3_U2Res[] normals;
        public Float4_U2Res[] tangents;
        public UVArray_U2Res[] uvChannels;
        public TriSubmesh_U2Res[] submeshes;
        public BlendShape_U2Res[] blendShapes;
        public Bone_U2Res[] bones;
        public BoneBinding_U2Res[] boneBindings;
    }
}

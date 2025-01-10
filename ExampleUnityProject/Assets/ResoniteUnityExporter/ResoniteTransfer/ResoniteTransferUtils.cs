using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ResoniteUnityExporter
{
    public class ResoniteTransferUtils
    {

        public class Timer : IDisposable
        {
            string name;
            long startMillis;
            public Timer(string name)
            {
                this.name = name;
                startMillis = System.Diagnostics.Stopwatch.GetTimestamp();
            }

            public void Dispose()
            {
                long elapsedMillis = System.Diagnostics.Stopwatch.GetTimestamp() - startMillis;
                Debug.Log(name + " elapsed " + elapsedMillis / 1000.0f);
            }
        }

        public static Matrix4x4_U2Res ConvertMatrix4x4(UnityEngine.Matrix4x4 mat)
        {
            return new Matrix4x4_U2Res()
            {
                m00 = mat.m00,
                m01 = mat.m01,
                m02 = mat.m02,
                m03 = mat.m03,
                m10 = mat.m10,
                m11 = mat.m11,
                m12 = mat.m12,
                m13 = mat.m13,
                m20 = mat.m20,
                m21 = mat.m21,
                m22 = mat.m22,
                m23 = mat.m23,
                m30 = mat.m30,
                m31 = mat.m31,
                m32 = mat.m32,
                m33 = mat.m33
            };
        }
        public static bool NotEmpty<T>(T[] arr)
        {
            return arr != null && arr.Length > 0;
        }


        public static void CheckAllEqual(object a, object b, string parentPrefix = "", Type type = null)
        {
            string fieldStr = parentPrefix + "." + (type == null ? "" : type.ToString());
            if (a == null || b == null)
            {
                if (a == b)
                {
                    Debug.Log("Matches " + fieldStr + " (both null)");
                }
                else
                {
                    Debug.LogError("Does not match (struct/class) " + fieldStr + " has values " + a + " and " + b);
                }
            }
            else
            {
                if (type == null) // default inits
                {
                    type = a.GetType();
                }
                if (ResoniteBridgeUtils.primitiveTypes.Contains(type) || type == typeof(System.String))
                {
                    // equality doesn't work because they are boxed, just use to string as good enough
                    if (a.ToString() == b.ToString())
                    {
                        Debug.Log("Matches " + fieldStr + " with values " + a + " " + b);
                    }
                    else
                    {
                        Debug.LogError("Does not match (primitive) " + fieldStr + " has values " + a + " and " + b);
                    }
                }
                else if (type.IsArray)
                {
                    int aLen = (int)a.GetType().GetProperty("Length")
                                    .GetValue(a, new object[] { });
                    int bLen = (int)b.GetType().GetProperty("Length")
                                    .GetValue(b, new object[] { });
                    if (aLen != bLen)
                    {
                        Debug.LogError("Does not match (array length) " + fieldStr + ".Length, has values " + aLen + " and " + bLen);
                    }
                    else
                    {
                        Debug.Log("Array length matches " + fieldStr + ".Length with lengths of " + aLen + " " + bLen);
                        var aGetMethod = a.GetType().GetMethod("GetValue", new Type[] { typeof(int) });
                        var bGetMethod = b.GetType().GetMethod("GetValue", new Type[] { typeof(int) });

                        Type elementType = a.GetType().GetElementType();
                        if (ResoniteBridgeUtils.TypeRecursivelyHasAllPrimitiveFields(elementType))
                        {
                            object[] args = new object[] { 0 };
                            int numNotMatches = 0;
                            byte[] aByte = ResoniteBridgeUtils.ToByteArray(a, elementType, aLen);
                            byte[] bByte = ResoniteBridgeUtils.ToByteArray(b, elementType, bLen);
                            for (int i = 0; i < aByte.Length; i++)
                            {
                                if (aByte[i] != bByte[i])
                                {
                                    numNotMatches += 1;
                                }
                            }
                            if (numNotMatches == 0)
                            {
                                Debug.Log("Array contents match " + fieldStr);
                            }
                            else
                            {
                                Debug.LogError("Array contents do not match " + fieldStr + " there are " + numNotMatches + " mismatched entries");
                            }
                        }
                        else
                        {
                            object[] parms = new object[] { 0 };

                            for (int i = 0; i < aLen; i++)
                            {
                                parms[0] = i;
                                var aVal = aGetMethod.Invoke(a, parms);
                                var bVal = bGetMethod.Invoke(b, parms);
                                CheckAllEqual(aVal, bVal, parentPrefix = parentPrefix + "." + type.ToString() + "[" + i + "]", type = elementType);
                            }
                        }
                    }
                }
                else
                {
                    foreach (FieldInfo field in ResoniteBridgeUtils.GetTypeFields(a.GetType()))
                    {
                        object valueA = field.GetValue(a);
                        object valueB = field.GetValue(b);
                        CheckAllEqual(valueA, valueB, parentPrefix = parentPrefix + "." + type.ToString(), type = field.FieldType);
                    }
                }
            }
        }
    }
}

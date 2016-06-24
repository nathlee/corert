// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// NOTE: This is a generated file - do not manually edit!

using System;
using System.Reflection;
using System.Collections.Generic;

#pragma warning disable 108     // base type 'uint' is not CLS-compliant
#pragma warning disable 3009    // base type 'uint' is not CLS-compliant
#pragma warning disable 282     // There is no defined ordering between fields in multiple declarations of partial class or struct

namespace Internal.Metadata.NativeFormat
{
    [Flags]
    public enum AssemblyFlags : uint
    {
        /// The assembly reference holds the full (unhashed) public key.
        PublicKey = 0x1,

        /// The implementation of this assembly used at runtime is not expected to match the version seen at compile time.
        Retargetable = 0x100,

        /// Reserved.
        DisableJITcompileOptimizer = 0x4000,

        /// Reserved.
        EnableJITcompileTracking = 0x8000,
    } // AssemblyFlags

    public enum AssemblyHashAlgorithm : uint
    {
        None = 0x0,
        Reserved = 0x8003,
        SHA1 = 0x8004,
    } // AssemblyHashAlgorithm

    [Flags]
    public enum FixedArgumentAttributes : byte
    {
        None = 0x0,

        /// Values should be boxed as Object
        Boxed = 0x1,
    } // FixedArgumentAttributes

    public enum GenericParameterKind : byte
    {
        /// Represents a type parameter for a generic type.
        GenericTypeParameter = 0x0,

        /// Represents a type parameter from a generic method.
        GenericMethodParameter = 0x1,
    } // GenericParameterKind

    public enum NamedArgumentMemberKind : byte
    {
        /// Specifies the name of a property
        Property = 0x0,

        /// Specifies the name of a field
        Field = 0x1,
    } // NamedArgumentMemberKind

    public enum HandleType : byte
    {
        Null = 0x0,
        ArraySignature = 0x1,
        ByReferenceSignature = 0x2,
        ConstantBooleanArray = 0x3,
        ConstantBooleanValue = 0x4,
        ConstantBoxedEnumValue = 0x5,
        ConstantByteArray = 0x6,
        ConstantByteValue = 0x7,
        ConstantCharArray = 0x8,
        ConstantCharValue = 0x9,
        ConstantDoubleArray = 0xa,
        ConstantDoubleValue = 0xb,
        ConstantHandleArray = 0xc,
        ConstantInt16Array = 0xd,
        ConstantInt16Value = 0xe,
        ConstantInt32Array = 0xf,
        ConstantInt32Value = 0x10,
        ConstantInt64Array = 0x11,
        ConstantInt64Value = 0x12,
        ConstantReferenceValue = 0x13,
        ConstantSByteArray = 0x14,
        ConstantSByteValue = 0x15,
        ConstantSingleArray = 0x16,
        ConstantSingleValue = 0x17,
        ConstantStringArray = 0x18,
        ConstantStringValue = 0x19,
        ConstantUInt16Array = 0x1a,
        ConstantUInt16Value = 0x1b,
        ConstantUInt32Array = 0x1c,
        ConstantUInt32Value = 0x1d,
        ConstantUInt64Array = 0x1e,
        ConstantUInt64Value = 0x1f,
        CustomAttribute = 0x20,
        CustomModifier = 0x21,
        Event = 0x22,
        Field = 0x23,
        FieldSignature = 0x24,
        FixedArgument = 0x25,
        GenericParameter = 0x26,
        MemberReference = 0x27,
        Method = 0x28,
        MethodImpl = 0x29,
        MethodInstantiation = 0x2a,
        MethodSemantics = 0x2b,
        MethodSignature = 0x2c,
        MethodTypeVariableSignature = 0x2d,
        NamedArgument = 0x2e,
        NamespaceDefinition = 0x2f,
        NamespaceReference = 0x30,
        Parameter = 0x31,
        ParameterTypeSignature = 0x32,
        PointerSignature = 0x33,
        Property = 0x34,
        PropertySignature = 0x35,
        QualifiedField = 0x36,
        QualifiedMethod = 0x37,
        ReturnTypeSignature = 0x38,
        SZArraySignature = 0x39,
        ScopeDefinition = 0x3a,
        ScopeReference = 0x3b,
        TypeDefinition = 0x3c,
        TypeForwarder = 0x3d,
        TypeInstantiationSignature = 0x3e,
        TypeReference = 0x3f,
        TypeSpecification = 0x40,
        TypeVariableSignature = 0x41,
    } // HandleType
} // Internal.Metadata.NativeFormat

// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_memory_object_sparse")]
    public unsafe partial class NVMemoryObjectSparse : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_object_sparse";
        [NativeApi(EntryPoint = "glBufferPageCommitmentMemNV")]
        public partial void BufferPageCommitmentMem([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glNamedBufferPageCommitmentMemNV")]
        public partial void NamedBufferPageCommitmentMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexPageCommitmentMemNV")]
        public partial void TexPageCommitmentMem([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexturePageCommitmentMemNV")]
        public partial void TexturePageCommitmentMem([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glBufferPageCommitmentMemNV")]
        public partial void BufferPageCommitmentMem([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexPageCommitmentMemNV")]
        public partial void TexPageCommitmentMem([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset, [Flow(FlowDirection.In)] bool commit);

        public unsafe void BufferPageCommitmentMem([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit)
        {
            // IntPtrOverloader
            BufferPageCommitmentMem(target, new IntPtr(offset), new UIntPtr(size), memory, memOffset, commit);
        }

        public unsafe void NamedBufferPageCommitmentMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit)
        {
            // IntPtrOverloader
            NamedBufferPageCommitmentMem(buffer, new IntPtr(offset), new UIntPtr(size), memory, memOffset, commit);
        }

        public unsafe void BufferPageCommitmentMem([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit)
        {
            // IntPtrOverloader
            BufferPageCommitmentMem(target, new IntPtr(offset), new UIntPtr(size), memory, memOffset, commit);
        }

        public NVMemoryObjectSparse(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

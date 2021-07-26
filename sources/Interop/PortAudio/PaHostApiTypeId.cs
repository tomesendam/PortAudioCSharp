// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public enum PaHostApiTypeId
    {
        paInDevelopment = 0,
        paDirectSound = 1,
        paMME = 2,
        paASIO = 3,
        paSoundManager = 4,
        paCoreAudio = 5,
        paOSS = 7,
        paALSA = 8,
        paAL = 9,
        paBeOS = 10,
        paWDMKS = 11,
        paJACK = 12,
        paWASAPI = 13,
        paAudioScienceHPI = 14,
    }
}